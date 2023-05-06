namespace lab2Api.DTO
{
    public class TopicCoursesDTO
    {
        public int ID { get; set; }
        public string? TopicName { get; set; }
        public List<string> crs_names { get; set; }= new List<string>();
    }
}
