using BloggieWeb.Models.Domain;

namespace BloggieWeb.Models.ViewModels
{
    public class EditTagRequest
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    
        public string DisplayName {  get; set; }

        public ICollection<BlogPost> BlogPosts { get; set; }
    }
}
