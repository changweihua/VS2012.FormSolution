using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Lucene.Net.Analysis;
using Lucene.Net.Analysis.Standard;
using Lucene.Net.Documents;
using Lucene.Net.Index;
using Lucene.Net.QueryParsers;
using Lucene.Net.Search;
using Lucene.Net.Store;
using NLite.Data;

namespace PanguApplication
{
    public partial class Form1 : Form
    {
        //生成索引文件的路径                                                
        private static readonly System.IO.FileInfo INDEX_DIR = new System.IO.FileInfo(Application.StartupPath + @"\index");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            skinEngine1.SkinFile = (Application.StartupPath + "\\Warm.ssk");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IndexWriter writer = new IndexWriter(FSDirectory.Open(new DirectoryInfo(INDEX_DIR.FullName)), new StandardAnalyzer(Lucene.Net.Util.Version.LUCENE_30), true, IndexWriter.MaxFieldLength.LIMITED);
            CreateIndex(writer, "cmono.net", "浩瀚无垠的世界中，会有一个网站叫cmono");

            CreateIndex(writer, "lucene.net测试", "这是一个测试，关于lucene.net的 关注CMONO.NET");

            CreateIndex(writer, "CMONO", "Hello World. 我认识的一个高手，他拥有广博的知识，有极客的态度，还经常到园子里来看看");

            CreateIndex(writer, "奥巴马", "美国现任总统是奥巴马？确定不是奥巴牛和奥巴羊 不知道问就别问了");

            CreateIndex(writer, "奥林匹克", "奥林匹克运动会将来到南美美丽热情的国度巴西，也就是亚马逊河流域的一个地方");

            CreateIndex(writer, "写给自己", "CMONO.NET之家的常伟华，新的开始，继续努力了");

            writer.Optimize();

            writer.Dispose();
        }

        private void CreateIndex(IndexWriter writer, string a, string b)
        {
            Document doc = new Document();
            doc.Add(new Field("title", a, Field.Store.YES, Field.Index.ANALYZED));
            doc.Add(new Field("content", b, Field.Store.YES, Field.Index.ANALYZED));

            writer.AddDocument(doc);
            writer.Commit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String field = "content";

            IndexReader reader = IndexReader.Open(FSDirectory.Open(new DirectoryInfo(INDEX_DIR.FullName)), true);

            Searcher searcher = new IndexSearcher(reader);
            Analyzer analyzer = new StandardAnalyzer(Lucene.Net.Util.Version.LUCENE_30);

            QueryParser parser = new QueryParser(Lucene.Net.Util.Version.LUCENE_30, field, analyzer);

            Query query = parser.Parse(textBox1.Text.Trim());

            TopScoreDocCollector collector = TopScoreDocCollector.Create(searcher.MaxDoc, false);
            searcher.Search(query, collector);
            ScoreDoc[] hits = collector.TopDocs().ScoreDocs;

            MessageBox.Show(this, "共 " + collector.TotalHits.ToString() + " 条记录");

            //ltrResult.Text = "共 " + collector.GetTotalHits().ToString() + " 条记录<br>";

            //for (Int32 i = 0; i < collector.GetTotalHits(); i++)
            //{
            //    ltrResult.Text += "doc=" + hits[i].doc + " score=" + hits[i].score + "<br>";
            //    Document doc = searcher.Doc(hits[i].doc);
            //    ltrResult.Text += "Path:" + doc.Get("path") + "<br>";
            //}

            reader.Dispose();

        }

        private string toBeIndexedFolder = "";

        private void button5_Click(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                toBeIndexedFolder = fbd.SelectedPath;
                System.DateTime start = System.DateTime.Now;

                try
                {

                    IndexWriter writer = new IndexWriter(FSDirectory.Open(new DirectoryInfo(INDEX_DIR.FullName)), new StandardAnalyzer(Lucene.Net.Util.Version.LUCENE_30), true, IndexWriter.MaxFieldLength.LIMITED);
                    listBox1.Text += "Indexing to directory '" + INDEX_DIR + "'... \r\n";
                    IndexDocs(writer, new FileInfo(toBeIndexedFolder));
                    listBox1.Text += "Optimizing... \r\n";
                    writer.Optimize();
                    writer.Close();

                    System.DateTime end = System.DateTime.Now;
                    listBox1.Text += "生成成功" + (end.Millisecond - start.Millisecond).ToString() + " total milliseconds <br>";
                }
                catch (System.IO.IOException ex)
                {
                    listBox1.Text += " caught a " + ex.GetType() + "\n with message: " + ex.Message;
                }

            }
        }

        private void IndexDocs(IndexWriter writer, System.IO.FileInfo file)
        {
            if (System.IO.Directory.Exists(file.FullName))
            {
                System.String[] files = System.IO.Directory.GetFileSystemEntries(file.FullName);

                if (files != null)
                {
                    for (int i = 0; i < files.Length; i++)
                    {
                        IndexDocs(writer, new System.IO.FileInfo(files[i]));
                    }
                }
            }
            else
            {
                try
                {
                    var doc = new Document();
                    doc.Add(new Field("path", file.FullName, Field.Store.YES, Field.Index.ANALYZED));
                    string content = "";
                    using (var reader = new StreamReader(file.FullName))
                    {
                        content = reader.ReadToEnd();
                    }
                    doc.Add(new Field("content", content, Field.Store.YES, Field.Index.ANALYZED));
                    writer.AddDocument(doc);
                }
                catch (System.IO.FileNotFoundException fnfe)
                {
                    listBox1.Text += "FileNotFoundException: " + fnfe.Message;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String field = "title";

            IndexReader reader = IndexReader.Open(FSDirectory.Open(new DirectoryInfo(INDEX_DIR.FullName)), true);

            Searcher searcher = new IndexSearcher(reader);
            Analyzer analyzer = new StandardAnalyzer(Lucene.Net.Util.Version.LUCENE_30);

            QueryParser parser = new QueryParser(Lucene.Net.Util.Version.LUCENE_30, field, analyzer);

            Query query = parser.Parse(textBox2.Text.Trim());

            TopScoreDocCollector collector = TopScoreDocCollector.Create(searcher.MaxDoc, false);
            searcher.Search(query, collector);
            ScoreDoc[] hits = collector.TopDocs().ScoreDocs;

            MessageBox.Show(this, "共 " + collector.TotalHits.ToString() + " 条记录");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var cfg = DbConfiguration.Configure("Mono").AddClass<Note>();
            IEnumerable<Note> notes = null;

            using (var db = cfg.CreateDbContext())
            {
                notes = db.Set<Note>().ToList();
            }

            IndexWriter writer = new IndexWriter(FSDirectory.Open(new DirectoryInfo(INDEX_DIR.FullName)), new StandardAnalyzer(Lucene.Net.Util.Version.LUCENE_30), true, IndexWriter.MaxFieldLength.LIMITED);

            foreach (var note in notes)
            {
                CreateIndex(writer, note.Title, note.Content);

            }
            writer.Optimize();
            writer.Dispose();
        }


    }
}
