using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_tests
{
    public static class Program
    {
        public static void Main()
        {}
    }

    public class Nucleotide
    {}

    public class DNA
    {
        //A, C, T, G
        private List<Nucleotide> nucleotides;
    }

    public class RNA
    {
        //A, C, U, G
        private List<Nucleotide> nucleotides;
    }

    /// <summary>
    /// Добавляет аминокислоты к месту синтеза белка(рибосоме)
    /// </summary>
    public class TransportRNA : RNA
    {
        private AminoAcid aminoAcid;
    }

    public class AminoAcid
    { }

    /// <summary>
    /// Кодирует последовательность белков, по три нуклеотида на аминокислоту
    /// </summary>
    public class MatrixRNA : RNA
    { }

    public class Ribosome
    {
        private RibosomeUnit ribosomeUnit1;
        private RibosomeUnit ribosomeUnit2;

        public Protein Translate(MatrixRNA mrna, IEnumerable<TransportRNA> trna)
        {
            return new Protein();
        }
    }

    public class Protein
    {
        private AminoAcid aminoAcid;
    }

    public class RibosomeRNA : RNA
    { }

    public class RNAPolymerase : Protein
    {
        public RNA Transcript(DNA dna)
        {
            throw new NotImplementedException();
        }
    }

    public class RibosomeUnit
    {
        private List<RibosomeRNA> ribosomeRnas;
        private List<Protein> proteins;
    }
}
