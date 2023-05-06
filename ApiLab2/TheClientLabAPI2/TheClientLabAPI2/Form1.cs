using System.Net.Http;
using TheClientLabAPI2.TheData;

namespace TheClientLabAPI2
{
    public partial class Form1 : Form
    {
        HttpClient client1;
        public Form1()
        {
            InitializeComponent();
            client1 = new HttpClient();
            client1.BaseAddress = new Uri("http://localhost:8088/");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HttpResponseMessage mess = client1.GetAsync("api/courses").Result;
            if (mess.IsSuccessStatusCode)
            {
                List<Course> CoursesList = mess.Content.ReadAsAsync<List<Course>>().Result;
                grd1.DataSource = CoursesList;
            }

            HttpResponseMessage messtopic = client1.GetAsync("api/topic").Result;
            if (mess.IsSuccessStatusCode)
            {
                List<Topic> TopicList = messtopic.Content.ReadAsAsync<List<Topic>>().Result;
                comtopicid.DataSource = TopicList;
                comtopicid.ValueMember = "id";
                comtopicid.DisplayMember = "topicName";
                
            }
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            Course cr = new Course()
            {
                crsId = int.Parse(txtid.Text),
                crsName = txtname.Text,
                crsDuration = int.Parse(textduration.Text),
                topId = (int)comtopicid.SelectedValue,
            };

            HttpResponseMessage messadd = client1.PostAsJsonAsync("api/courses",cr).Result;
            //MessageBox.Show(messadd.Headers.ToString());
            if (messadd.IsSuccessStatusCode)
            {
                MessageBox.Show("Added Succefly");
                Form1_Load(null, null);
            }
            else
            {
                MessageBox.Show("Error Try Again");
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            HttpResponseMessage mess = client1.GetAsync("api/courses").Result;
            List<Course> CoursesList = mess.Content.ReadAsAsync<List<Course>>().Result;
            var id = int.Parse(txtid.Text);

            foreach (var item in CoursesList)
            {
                if (item.crsId == id)
                {
                    HttpResponseMessage messdelete = client1.DeleteAsync($"api/courses/{id}").Result;
                    if (messdelete.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Deleted Succefully");
                        Form1_Load(null, null);
                    }
                }
            }

        }
    }
}
