using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace Dijkstra
{
    public class Grafo : Panel
    {
        //public List<Vertice> vertici;
        //public List<Vertice> frontiera;
        public List<Vertice> nonVisitati;
        public List<Vertice> visitati;
        public Vertice Attivo { get; set; }

        public Grafo()
        {
            nonVisitati = new List<Vertice>();
            //frontiera = new List<Vertice>();
            visitati = new List<Vertice>();
            //vertici = new List<Vertice>();
            this.BorderStyle = BorderStyle.Fixed3D;
            this.BackColor = Color.White;
            this.Size = new Size(1500, 900);
            for (int i = 0; i < 15; i++)
                for (int j = 0; j < 25; j++)
                {
                    Postazione p = new Postazione(i, j);

                    p.Location = new Point(j * 60, i * 60);

                    this.Controls.Add(p);
                }
        }

        public Grafo(Grafo grafo)
        {
            this.nonVisitati = new List<Vertice>(grafo.nonVisitati);
            this.visitati = new List<Vertice>(grafo.visitati);
            this.Attivo = grafo.Attivo;
        }

        public void AggiungiVertice(Vertice v)
        {
            nonVisitati.Add(v);
        }

        public void SpostaVisitati(Vertice v)
        {

            nonVisitati.Remove(v);
            visitati.Add(v);

        }

        public void Visita()
        {
            Attivo = visitati.ElementAt(0);
            if (!Attivo.Visitato)
            {
                Attivo.Visitato = true;

                visitati.Add(Attivo);
            }

            visitati.RemoveAt(0);
        }

        public void Relax(Arco arco)
        {

            if (!arco.Destinazione.Visitato && arco.Destinazione.Peso > Attivo.Peso + arco.Peso)
            {
                Console.WriteLine("Relax");
                arco.Destinazione.Peso = Attivo.Peso + arco.Peso;
                arco.Destinazione.Predecessore = Attivo;
            }
            
        }

        public bool Aggiornamento(Arco arco)
        {
        
            if (arco.Destinazione.Peso > arco.Sorgente.Peso + arco.Peso)
            {
                Console.WriteLine("Relax");
                arco.Destinazione.Peso = arco.Sorgente.Peso + arco.Peso;
                arco.Destinazione.Predecessore = arco.Sorgente;
                return true;
            }

            return false;

        }

        public Vertice DaNome(string nome)
        {
             var query = from vertice in nonVisitati
                        where vertice.Nome == nome
                        select vertice;
            return query.First();
        }
        

    /*  public void InizializzaSorgenteSingola(Vertice v)
      {
          v.Peso = 0;
          SpostaVisitati(v);
      }

      public void AggiungiNodo(Vertice v)
      {
          vertici.Add(v);
          Controls.Add(v);
      }*/

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics gr = e.Graphics;
            foreach (Control c in Controls)
            {
                Postazione p = c as Postazione;
                if (p != null && p.Controls.Count > 0)
                {
                    Vertice v = p.Controls[0] as Vertice;
                    if (v != null)
                    {
                        for (int i = 0; i < v.listaAdiacenti.Count; i++)
                        {
                            Brush b = Brushes.Blue;
                            Brush y = Brushes.RosyBrown;
                            gr.DrawLine(new Pen(Color.Red, 2), new Point(v.Posx + 30, v.Posy + 30), new Point(v.listaAdiacenti[i].Destinazione.Posx + 30, v.listaAdiacenti[i].Destinazione.Posy + 30));
                            gr.DrawString(v.listaAdiacenti[i].Peso.ToString(), new Font("Arial", 14F), y, new PointF((float)((v.Posx + v.listaAdiacenti[i].Destinazione.Posx) / 2), (float)(v.Posy + v.listaAdiacenti[i].Destinazione.Posy) / 2));
                        }
                    }                
                    
                }
            }
            base.OnPaint(e);
        }
                

    }

      
}
