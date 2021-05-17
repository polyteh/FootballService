namespace StatisticsClient.Models.RapidapiModels
{
    public abstract class BaseRapidapiResponse<T>
    {
        public string Get { get; set; }
        public Parameters Parameters { get; set; }
//        public List<object> errors { get; set; }
        public int Results { get; set; }
        public Paging Paging { get; set; }
        public T Response { get; set; }
    }

    public class Parameters
    {
        public string League { get; set; }
        public string Season { get; set; }
    }

    public class Paging
    {
        public int Current { get; set; }
        public int Total { get; set; }
    }
}
