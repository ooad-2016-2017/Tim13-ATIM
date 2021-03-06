﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace ProjekatMEDICA.Models
{
    public class Proizvod
    {
        string naziv, id, opis, proizvodjac;
        double cijena;
        string komentar;
        int kolicina;
        public Proizvod()
        {
        }

        //barcode

        public Proizvod(string naz, string id, string proizv, string opis, double cijena, int kolicina, string komentar)
        {
            Naziv = naz;
            Id = id;
            Proizvodjac = proizv;
            Opis = opis;
            Cijena = cijena;
            Komentar = komentar;
            Kolicina = kolicina;
        }
        public Proizvod(Proizvod p)
        {
            Naziv = p.Naziv;
            Id = p.Id;
            Proizvodjac = p.Proizvodjac;
            Opis = p.Opis;
            Cijena = p.Cijena;
            Komentar = p.Komentar;
        }

        public string Naziv { get => naziv; set => naziv = value; }
        public string Opis { get => opis; set => opis = value; }
        public string Proizvodjac { get => proizvodjac; set => proizvodjac = value; }
        public string Id { get => id; set => id = value; }
        public double Cijena { get => cijena; set => cijena = value; }
        public string Komentar { get => komentar; set => komentar = value; }
        public int Kolicina { get => kolicina; set => kolicina = value; }
    }
}
