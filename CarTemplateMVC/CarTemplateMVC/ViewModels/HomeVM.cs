using CarTemplateMVC.Models;

namespace CarTemplateMVC.ViewModels
{
    public class HomeVM // viewModel
    {
        public List<Client> Clients { get; set; }
        public List<Technician> Technicians { get; set; }
    }
}
