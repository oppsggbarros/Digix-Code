using System;

namespace Taxonomia
{ 
    public abstract class Animalia
    {
        public abstract string Nome { get; }
        public abstract string ObterDescricao();
    }

    public abstract class Chordata : Animalia
    {
        public override string ObterDescricao()
        {
            return $"Reino Animalia\nFilo Chordata";
        }
    }

    public abstract class Arthropoda : Animalia
    {
        public override string ObterDescricao()
        {
            return $"Reino Animalia\nFilo Arthropoda";
        }
    }

   
    public abstract class Mammalia : Chordata
    {
        public override string ObterDescricao()
        {
            return base.ObterDescricao() + "\nClasse Mammalia";
        }
    }

    public abstract class Insecta : Arthropoda
    {
        public override string ObterDescricao()
        {
            return base.ObterDescricao() + "\nClasse Insecta";
        }
    }

    public abstract class Primata : Mammalia
    {
        public override string ObterDescricao()
        {
            return base.ObterDescricao() + "\nOrdem Primata";
        }
    }

    public abstract class Carnivora : Mammalia
    {
        public override string ObterDescricao()
        {
            return base.ObterDescricao() + "\nOrdem Carnivora";
        }
    }

    public abstract class Diptera : Insecta
    {
        public override string ObterDescricao()
        {
            return base.ObterDescricao() + "\nOrdem Diptera";
        }
    }

  
    public abstract class Hominidae : Primata
    {
        public override string ObterDescricao()
        {
            return base.ObterDescricao() + "\nFamília Hominidae";
        }
    }

    public abstract class Canidae : Carnivora
    {
        public override string ObterDescricao()
        {
            return base.ObterDescricao() + "\nFamília Canidae";
        }
    }

    public abstract class Muscidae : Diptera
    {
        public override string ObterDescricao()
        {
            return base.ObterDescricao() + "\nFamília Muscidae";
        }
    }
    public abstract class Homo : Hominidae
    {
        public override string ObterDescricao()
        {
            return base.ObterDescricao() + "\nGênero Homo";
        }
    }

    public abstract class Canis : Canidae
    {
        public override string ObterDescricao()
        {
            return base.ObterDescricao() + "\nGênero Canis";
        }
    }

    public abstract class Musca : Muscidae
    {
        public override string ObterDescricao()
        {
            return base.ObterDescricao() + "\nGênero Musca";
        }
    }

    // Classe Espécie
    public class HomoSapiens : Homo
    {
        public override string Nome => "Homo sapiens";

        public override string ObterDescricao()
        {
            return base.ObterDescricao() + "\nEspécie Homo sapiens";
        }
    }

    public class CanisFamiliaris : Canis
    {
        public override string Nome => "Canis familiaris";

        public override string ObterDescricao()
        {
            return base.ObterDescricao() + "\nEspécie Canis familiaris";
        }
    }

    public class MuscaDomestica : Musca
    {
        public override string Nome => "Musca domestica";

        public override string ObterDescricao()
        {
            return base.ObterDescricao() + "\nEspécie Musca domestica";
        }
    }

    public class Program
    {
        public static void Mn(string[] args)
        {
            Animalia humano = new HomoSapiens();
            Animalia cachorro = new CanisFamiliaris();
            Animalia mosca = new MuscaDomestica();

            Console.WriteLine(humano.ObterDescricao());
            Console.WriteLine();

            Console.WriteLine(cachorro.ObterDescricao());
            Console.WriteLine();

            Console.WriteLine(mosca.ObterDescricao());
        }
    }
}
