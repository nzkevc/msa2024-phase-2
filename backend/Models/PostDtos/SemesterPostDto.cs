namespace Models

{
    public class SemesterPostDto
    {
        public required string Name { get; set; }
        public required int Year { get; set; }
        public List<int>? CourseIds { get; set; }
    }
}