using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //Зд 2.

            Console.Write("Введите ключь: ");
            string sireal = Console.ReadLine();

            DocumentWorker free = new DocumentWorker();

            ProDocumentWorker pro = new ProDocumentWorker();

            ExpertDocumentWorker expert = new ExpertDocumentWorker();


            if (sireal == "pro")
            {
                pro.EditDocument();
                pro.SaveDocument();
            }
            if (sireal == "exp")
            {
                expert.SaveDocument();
            }
            else
            {
                free.OpenDocument();
                free.EditDocument();
                free.SaveDocument();
            }


            //Зд 3.

            IPlayable Play = new Player();
            IRecodable Record = new Player();

            Console.WriteLine();
            Play.Play();
            Play.Pause();
            Play.Stop();

            Console.WriteLine();
            Record.Record();
            Record.Pause();
            Record.Stop();
        }
    }

    //Зд 2.
    public class DocumentWorker
    {
        public void OpenDocument()
        {
            Console.WriteLine();
            Console.WriteLine("Документ открыт");
        }
        public virtual void EditDocument()
        {
            Console.WriteLine();
            Console.WriteLine("Редактирование документа доступно в версии Pro");
        }
        public virtual void SaveDocument()
        {
            Console.WriteLine();
            Console.WriteLine("Сохранение документа доступно в версии Pro");
        }
    }


    public class ProDocumentWorker : DocumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine();
            Console.WriteLine("Документ отредактирован");
        }
        public override void SaveDocument()
        {
            Console.WriteLine();
            Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Expert");
        }
    }


    public class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void SaveDocument()
        {
            Console.WriteLine();
            Console.WriteLine("Документ сохранен в новом формате");
        }
    }

    //Зд 3.

    interface IPlayable
    {
        void Play();
        void Pause();
        void Stop();


    }

    public interface IRecodable
    {
        void Record();
        void Pause();
        void Stop();

    }


    class Player : IPlayable, IRecodable
    {
        public void Play()
        {
            Console.WriteLine("Play");
        }
        public void Pause()
        {
            Console.WriteLine("Pause");
        }
        public void Stop()
        {
            Console.WriteLine("Stop");
        }
        public void Record()
        {
            Console.WriteLine("Record");
        }


    }
}
