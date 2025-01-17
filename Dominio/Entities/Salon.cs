namespace Dominio;
    public class Salon
    {
        public int IdSalon { get; set; }
        public string NombreSalon { get; set; }
        public int Capacidad { get; set; }
        public ICollection<Matricula> Matriculas { get; set; }
        public ICollection<TrainerSalon> TrainerSalones { get; set; }
    }