

namespace interfaces
{

    public interface icamara
    {
        void show_app();
        void take_photo();
        string name_photo { get; set; }
        int amount { get; set; }
    }

    public class Tablets : icamara
    {
        public string name_photo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int amount { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void show_app()
        {
            Console.WriteLine("The camera application is showing on your tablet");
        }

        public void take_photo()
        {
            throw new NotImplementedException();
        }
    }

    public class celphone : icamara
    {
        public string name_photo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int amount { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void show_app()
        {
            Console.WriteLine("The camera application is showing on your phone");
        }

        public void take_photo()
        {
            throw new NotImplementedException();
        }
    }
    class program
        {
            static void Main(string[] args)
            {
                celphone phone = new celphone();
                phone.show_app();

                Tablets tablet = new Tablets();
                tablet.show_app();
                
                Console.ReadKey();
            }
        }
    







}

