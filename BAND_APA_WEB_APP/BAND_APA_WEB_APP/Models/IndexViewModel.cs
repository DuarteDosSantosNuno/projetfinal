namespace BAND_APA_WEB_APP.Models
{
    public class IndexViewModel
    {
        public List<Animal> Animals { get; set; }
        public List<Animal> FiltersSelectors { get; set; }

        public IndexViewModel(List<Animal> animals, List<Animal> filtersSelectors)
        {
            this.Animals = animals;
            this.FiltersSelectors = filtersSelectors;
        }
    }
}
