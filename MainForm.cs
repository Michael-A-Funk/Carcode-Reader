using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.UI;
using Emgu.CV.Structure;

namespace SS_OpenCV
{
    public partial class MainForm : Form
    {
        Image<Bgr, Byte> img = null;
        Image<Bgr, Byte> imgUndo = null;

        Image<Bgr, Byte> img1 = null;
       

        Image<Bgr, Byte> img_letra_mtr = null;
        Image<Bgr, Byte> img_matricula = null;

        Image<Bgr, Byte> img_original = null;
        
        

        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Abrir uma nova imagem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {                  
                img = new Image<Bgr, byte>(openFileDialog1.FileName);
                imgUndo = img.Copy();
                // outra image box que a principal
                //pictureBox1.Image = img.Bitmap;
                //pictureBox1.Refresh();
                ImageApl.Image = img.Bitmap;
                ImageApl.Refresh();
            }
        }

        /// <summary>
        /// Guardar a imagem com novo nome
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ImageApl.Image.Save(saveFileDialog1.FileName);
            }
        }

        /// <summary>
        /// Fecha a aplicação
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// repoe a ultima copia da imagem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            img = imgUndo.Copy();
            ImageApl.Image = img.Bitmap;
            ImageApl.Refresh();
            Cursor = Cursors.Default;
        }

        /// <summary>
        /// Altera o modo de vizualização
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void autoZoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // zoom
            if (autoZoomToolStripMenuItem.Checked)
            {
                //ImageApl.SizeMode = PictureBoxSizeMode.Zoom;
                //ImageApl.Dock = DockStyle.Fill;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.Dock = DockStyle.Fill;
            }
            else // com scroll bars
            {
                //ImageApl.Dock = DockStyle.None;
                //ImageApl.SizeMode = PictureBoxSizeMode.AutoSize;
                pictureBox1.Dock = DockStyle.None;
                pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            }
        }

        /// <summary>
        /// Mostra a janela Autores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void autoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AuthorsForm form = new AuthorsForm();
            form.ShowDialog();
        }


        /// <summary>
        /// Converte a imagem para tons de cinzento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void grayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (img == null)
                return;
            Cursor = Cursors.WaitCursor;

            //copy Undo Image
            imgUndo = img.Copy();

            ImageClass.ConvertToGray(img);

            ImageApl.Refresh();
            Cursor = Cursors.Default;
        }

        /// <summary>
        /// Efectua o negativo da imagem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void negativeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (img == null)
                return;
            Cursor = Cursors.WaitCursor;

            //copy Undo Image
            imgUndo = img.Copy();

            ImageClass.Negative(img);

            ImageApl.Refresh();
            Cursor = Cursors.Default;
        }

        private void negative2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (img == null)
                return;
            Cursor = Cursors.WaitCursor;




            //copy Undo Image
            imgUndo = img.Copy();

            ImageClass.Negative2(img);

            ImageApl.Refresh();
            Cursor = Cursors.Default;

        }

        private void translationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (img == null)
                return;
            Cursor = Cursors.WaitCursor;

            //copy Undo Image
            imgUndo = img.Copy();

            ImageClass.translacao(img, imgUndo, 100, 100);

            ImageApl.Refresh();
            Cursor = Cursors.Default;
        }

        private void MediaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (img == null)
                return;
            Cursor = Cursors.WaitCursor;

            //copy Undo Image
            imgUndo = img.Copy();

            ImageClass.media(img, imgUndo);

            ImageApl.Refresh();
            Cursor = Cursors.Default;
        }

        private void rotationInverseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (img == null)
                return;
            Cursor = Cursors.WaitCursor;

            //copy Undo Image
            imgUndo = img.Copy();

            ImageClass.rotationInverse(img, imgUndo, 75);

            ImageApl.Refresh();
            Cursor = Cursors.Default;

        }

        private void mediaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (img == null)
                return;
            Cursor = Cursors.WaitCursor;

            //copy Undo Image
            imgUndo = img.Copy();

            ImageClass.media(img, imgUndo);

            ImageApl.Refresh();
            Cursor = Cursors.Default;

        }

        private void mediaPonderadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (img == null)
                return;
            Cursor = Cursors.WaitCursor;

            //copy Undo Image
            imgUndo = img.Copy();
            FilterForm form = new FilterForm();
            form.ShowDialog();

            int c11 = Convert.ToInt32(form.c11.Text);
            int c12 = Convert.ToInt32(form.c12.Text);
            int c13 = Convert.ToInt32(form.c13.Text);
            int c21 = Convert.ToInt32(form.c21.Text);
            int c22 = Convert.ToInt32(form.c22.Text);
            int c23 = Convert.ToInt32(form.c23.Text);
            int c31 = Convert.ToInt32(form.c31.Text);
            int c32 = Convert.ToInt32(form.c32.Text);
            int c33 = Convert.ToInt32(form.c33.Text);
            int peso = Convert.ToInt32(form.Peso.Text);

            ImageClass.media_ponderada(img, imgUndo, c11, c12, c13, c21, c22, c23, c31, c32, c33, peso);

            ImageApl.Refresh();
            Cursor = Cursors.Default;
        }

        private void sobelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (img == null)
                return;
            Cursor = Cursors.WaitCursor;

            //copy Undo Image
            imgUndo = img.Copy();

            ImageClass.Sobel(img, imgUndo);

            ImageApl.Refresh();
            Cursor = Cursors.Default;

        }

        private void binarizacaoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void histogramaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (img == null)
                return;
            Cursor = Cursors.WaitCursor;

            //copy Undo Image
            imgUndo = img.Copy();

            ImageClass.Histograma(img, imgUndo);

            int[] vector = ImageClass.Histograma(img, imgUndo);
            Histogram form = new Histogram(vector);
            form.ShowDialog();

            ImageApl.Refresh();
            Cursor = Cursors.Default;
        }

        private void binarizacaoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void escolherValorToolStripMenuItem_Click(object sender, EventArgs e)
        {   if (img == null)
                return;
            Cursor = Cursors.WaitCursor;

            InputBox form = new InputBox();
            form.ShowDialog();

            int val = Convert.ToInt32(form.val.Text);

            //copy Undo Image
            imgUndo = img.Copy();

            ImageClass.Binarizacao(img, imgUndo, val);


            ImageApl.Refresh();
            Cursor = Cursors.Default;

        }
        
        
        private void automáticaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
        }

        private void otsuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (img == null)
                return;
            Cursor = Cursors.WaitCursor;

            //copy Undo Image
            imgUndo = img.Copy();

            int valor = ImageClass.Otsu(img, imgUndo);
            ImageClass.Binarizacao(img, imgUndo, valor);



            ImageApl.Refresh();
            Cursor = Cursors.Default;



        }
//---------------------------------------TRANSIÇÃO DE INTENSIDADES------------------------------------

        private void transicaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (img == null)
                return;
            Cursor = Cursors.WaitCursor;

            //copy Undo Image
            imgUndo = img.Copy();
            ImageClass.Transicao(img, imgUndo, 0, 0);

            // ESTA PARTE SERVE SÓ PARA VISUALIZAR RESULTADOS
            
            int[,] intensidades = ImageClass.Transicao(img, imgUndo, 0, 0);
            int i; int[] vector_x = new int[img.Width]; int[] vector_y = new int[img.Height];

            for (i = 0; i < Math.Max(img.Width, img.Height); i++)
            {
                if (i < img.Width)
                { vector_x[i] = intensidades[0, i]; }
                if (i < img.Height)
                { vector_y[i] = intensidades[1, i]; }
            }

            // visualizar histograma da projecção das linhas
            //Histogram form = new Histogram(vector_x);
            //form.ShowDialog();

            //visualizar histograma da projecção das colunas
            Histogram form2 = new Histogram(vector_y);
            form2.ShowDialog();

            // CONTINUAÇÃO DO PROGRAMA PRINCIPAL 

            ImageApl.Refresh();
            Cursor = Cursors.Default;
        }

// A PARTIR DAQUI COMEÇAM OS SEGMENTOS A JUNTAR NO FINAL PARA O PROGRAMA "RECONHECIMENTO DE MATRICULAS"

// --------------------------------------CORTA MATRICULA-----------------------------------

       private void ImageApl_Click(object sender, EventArgs e)
        {

        }
// PICTURE BOXS 
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

// -----        

        private void cortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (img == null)
                return;
            Cursor = Cursors.WaitCursor;
            imgUndo = img.Copy();
            


            //1ª FASE DO CORTE, E RESPECTIVA ANALISE DE VALORES --------------------------
            // (APENAS CORTANDO A IMAGEM A PARTIR DOS LIMITES DE TRANSIÇÃO NAS PROJECÇOES DAS COLUNAS E
            //   

            //declarão das variáveis atribuidas às intensidade das projecções em x e y
            int[,] intensidades = ImageClass.Transicao(img, imgUndo, 0, 0); //busca a soma das intensidades de cada linha, e colunas
            int i; int[] vector_x = new int[img.Width]; int[] vector_y = new int[img.Height];

            for (i = 0; i < img.Height; i++)
            { { vector_y[i] = intensidades[1, i]; } }

            // declaração das variáveis para operações de limitar àrea à matricula
            int x_max, y_max = 0, maximo = 0, width = img.Width, height = img.Height;
            int lim_up = 0, lim_down = 0, lim_dir = 0, lim_esq = 0;

            // achar linha com intensidade máxima 
            for (i = 0; i < img.Height; i++)
            {
                if (vector_y[i] > maximo)
                {
                    maximo = vector_y[i];
                    y_max = i;
                }

            }

            //achar os limites superior e inferior da matricula
            for (i = y_max; i > 0; i--)
            {
                if (vector_y[i] < 25)
                {
                    lim_up = i;
                    break;
                }
            }
            for (i = y_max; i < img.Height; i++)
            {
                if (vector_y[i] < 25)
                {
                    lim_down = i;
                    break;
                }
            }
            // buscar o resultado da transicao ignorando o que está fora dos limites

            //int[,] intensidades2 = ImageClass.Transicao(img, imgUndo, 0,0);

            int[,] intensidades2 = ImageClass.Transicao(img, imgUndo, lim_up, lim_down);

            for (i = 0; i < img.Width; i++)
            {
                vector_x[i] = intensidades2[0, i];
            }
            
            //visualizar histograma da projecção das colunas

            Histogram form2 = new Histogram(vector_x);
            form2.ShowDialog();

            // achar coluna com intensidade máxima (ignorando primeiro 1/3 da img i.e. as rodas)
            x_max = 0;
            maximo = 0;
            for (i = (img.Width) / 3; i < (img.Width); i++)
            {
                if (vector_x[i] > maximo)
                {   
                    maximo = vector_x[i];
                    x_max = i;
                }

            }
            //achar os limites direito e esquerdo da matricula
            int contador = 0;
            for (i = x_max; i > (img.Width) / 3; i--)
            {
                if (vector_x[i] < 1 && contador < 10)
                {
                    contador++;
                }
                else if (vector_x[i] < 1 && contador == 10)
                { lim_esq = i + 10; break; }
                else
                {
                    if (vector_x[i] > 1)
                    { contador = 0; }
                }


            }
            contador = 0;
            for (i = x_max; i < (img.Width); i++)
            {
                if (vector_x[i] < 1 && contador < 10)
                {
                    contador++;
                }
                else if (vector_x[i] < 1 && contador == 10)
                { lim_dir = i - 10; break; }
                else
                {
                    if (vector_x[i] > 1)
                    { contador = 0; }
                }
            }


            //serviu para ver o corte apenas a linha limite superior e inferior a partir do máximo de projecção da linha
            //img = imgUndo.Copy(new Rectangle(0, lim_up, width, lim_down - lim_up));

            img = imgUndo.Copy(new Rectangle(lim_esq, lim_up, lim_dir - lim_esq, lim_down - lim_up));
            

            ImageApl.Image = img.Bitmap;
            ImageApl.Refresh();
            Cursor = Cursors.Default;
        }
    //PARAR DE COPIAR AQUI

  // ESTA FUNÇÃO SERVE SÓ PARA O TESTES E PARA O RELATÓRIO ----------------

        private void graficoProjecçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (img == null)
                return;
            Cursor = Cursors.WaitCursor;

            // COMEÇAR A CORTAR A PARTIR DAQUI NOVAMENTE 

            //2ª FASE DO CORTE - CORTAR AS LETRAS---------------------------------------

            //copy Undo Image
            imgUndo = img.Copy();
            ImageClass.Binarizacao(img, imgUndo, ImageClass.Otsu(img, imgUndo));

            imgUndo = img.Copy();

            int[,] escuros = ImageClass.graficoProjecções(img, imgUndo,0);
            //declarão das variáveis atribuidas às intensidade das projecções em x e y
            int i; int[] vector_x = new int[img.Width]; int[] vector_y = new int[img.Height];
            for (i = 0; i < Math.Max(img.Width, img.Height); i++)
            {
                if (i < img.Width)
                { vector_x[i] = escuros[0, i]; }
                if (i < img.Height)
                { vector_y[i] = escuros[1, i]; }
            }

            
            // visualizar histograma da projecção das linhas    
            Histogram form = new Histogram(vector_x);
            form.ShowDialog();

            //visualizar histograma da projecção das colunas
            Histogram form2 = new Histogram(vector_y);
            form2.ShowDialog();

            //DAQUI SE TIRA INFORMAÇOES QUE LEVAM à CONCLUSAO DE QUE:
            // a) Não existe nenhuma linha na parte das letras onde nºde escuros atravesse
            //    totamente esta parte. -> Daí que as que houverem assim tiram-se (=0)
            // b) existem no minimo 6 transições-> linhas com menos de 6 transições tiram-se           
            // c) TENDO TIRADO JÁ FILTRADO AS LINHAS DESINTERESSANTES:
            //      -existe no máximo 9 transições, podendo haver também 7, ou 6 (minimo)   
            //      -sabendo o nº transições para cada matricula, sabe-se que colunas tirar (pontos e barras)

                  

            ImageApl.Refresh();
            Cursor = Cursors.Default;

        }

//-------COPIAR A PARTIR DAQUI NOVAMENTE ------------------

//--------------- BUSCAR E COMPARAR LETRAS -------------------
        
        private void buscarLetrasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // 2ª FASE DE CORTE - FINALMENTE SEPARAR AS LETRAS

            if (img == null)
                return;
            Cursor = Cursors.WaitCursor;
            
            //copy Undo Image
            imgUndo = img.Copy();
            ImageClass.Binarizacao(img, imgUndo, ImageClass.Otsu(img, imgUndo));

            imgUndo = img.Copy();

            int[,] escuros = ImageClass.graficoProjecções(img, imgUndo,1); // corta linhas desnecessárias
                   
            
            //declarão das variáveis atribuidas às intensidade das projecções em x e y
            int i; int[] vector_y = new int[img.Height];
            for (i = 0; i < img.Height; i++)
            { vector_y[i] = escuros[1, i]; }             
                       
            // TESTES DE PROJECÇÃO das Linhas

           
            //visualizar histograma da projecção das colunas
            Histogram form2 = new Histogram(vector_y);
            form2.ShowDialog();

            //----------------FIM TESTES 

           
            // OBTER E MOSTRAR A IMAGEM CORTADA (APENAS LINHAS QUE PERTENÇAM ÀS LETRAS) ------------------
                        

            int y, contador = 0; int[] limites = new int[2];
            if (escuros[1, 0] == 1)
            {
                limites[0] = 0;
                contador++;
            }
            limites[1]=(img.Height)-1;
                    
            
            for (y=0; y<img.Height-1 ; y++ )
            {
                if (escuros[1, y] != escuros[1, y+1] && contador < 2)
                {
                    limites[contador] = (contador==1)?y+1:y;
                    contador++;  
                }

                if (contador>=2) break;
                
                    
            }

            img = img.Copy(new Rectangle(0,limites[0], img.Width, limites[1]-limites[0]));
            
            //---FIM DA 2ª FASE DE CORTE 

            //TIRA AS POSIÇÕES PARA CORTE DE LETRAS
            int [] vector_x = new int[img.Width];
                
            int[,] escuros2 = ImageClass.graficoProjecções(img, imgUndo, 1);
            
            for (i = 0; i < img.Width; i++)
            { vector_x[i] = escuros2[0, i]; }

            // visualizar histograma da projecção das linhas    
            Histogram form = new Histogram(vector_x);
            form.ShowDialog();

            contador = 0; int valor, valor_ant=0,cont_lim=0;
            int[] limites_x = new int[12];
            for (i = 0; i < img.Width; i++)
            {   
                if (vector_x[i] != 0)
                { valor = 1;
                if (i < img.Width - 2)
                    {
                        if (vector_x[i + 1] == 0)
                        { valor = 0; }
                    }
                }
                else
                { valor = 0; }

                if (valor_ant != valor && cont_lim<4)
                {   
                    limites_x[contador] = (valor == 0) ? i-1 : i;
                    contador++;
                    cont_lim++;
                    if (contador == 12) break;

                }
                else if (valor_ant != valor && cont_lim >= 4)
                {
                        if (cont_lim == 4)
                        { cont_lim++; }
                        else
                        { cont_lim = 0; }
                }
                
                valor_ant = valor;
            }

            BasedeDados.Items.Clear();
            //CORTA LETRAS E COMPARA COM A BASE DE DADOS
            int j = 0;
            int lim_dir, lim_esq; char letra_identif;
            for (i=0; i<6; i++)      // 6              
                                 
              {   lim_dir = limites_x[j+1];
                  lim_esq = limites_x[j];
                
                  img_letra_mtr = img.Copy(new Rectangle(lim_esq, 0, lim_dir - lim_esq+1, img.Height));
                        if (i==0){  pictureBox1.Image = img_letra_mtr.Bitmap;pictureBox1.Refresh();}
                        if (i==1){  pictureBox2.Image = img_letra_mtr.Bitmap;pictureBox2.Refresh();}
                        if (i==2){  pictureBox3.Image = img_letra_mtr.Bitmap;pictureBox3.Refresh();}
                        if (i==3){  pictureBox4.Image = img_letra_mtr.Bitmap;pictureBox4.Refresh();}
                        if (i==4){  pictureBox5.Image = img_letra_mtr.Bitmap;pictureBox5.Refresh();}
                        if (i==5){  pictureBox6.Image = img_letra_mtr.Bitmap;pictureBox6.Refresh();}
                        
                        img_letra_mtr=img_letra_mtr.Resize(12, 18, Emgu.CV.CvEnum.INTER.CV_INTER_AREA);
                  ImageClass.Binarizacao(img_letra_mtr, img_letra_mtr, ImageClass.Otsu(img_letra_mtr, imgUndo));      
                        j = j + 2;
                        
                        //int[,] matriz = ImageClass.ComparaLetras(img_letra_mtr, imgUndo,25);                                      
                       

                        //for (z=0; z<(img_letra_mtr.Height*img_letra_mtr.Width) ; z++)
                        {  // BasedeDados.Items.Add(matriz[0,z]);
                            //Matricula.Items.Add(matriz[1, z]);

                            }

                        letra_identif = ImageClass.ComparaLetras(img_letra_mtr, imgUndo);                        
                        BasedeDados.Items.Add(letra_identif);
                        if (i == 1 || i == 3) 
                        {BasedeDados.Items.Add("-");}
            }

            //TESTE DO APARECER DAS LETRAS DA BASE DE DADOS
            //String imgpath = null;
            //imgpath = "C:\\Documents and Settings\\Michael\\Ambiente de trabalho\\SS_OpenCV\\SS_OpenCV\\bin\\Debug\\Base Dados\\A.bmp";
            //img = new Image<Bgr, byte>(imgpath);
            //ImageClass.Binarizacao(img1, imgUndo, ImageClass.Otsu(img1, img1Undo));
            //----

            
            //           
            //img = img.Copy(new Rectangle(0, limites[0], img.Width, limites[1] - limites[0]));
            //img1Undo = img1.Copy();
            
            //FIM DE OPERAÇÕES TODAS-----

            
            //pictureBox1.Image = img1.Bitmap;
            //pictureBox1.Refresh();
            ImageApl.Image = img.Bitmap;
            ImageApl.Refresh();
            Cursor = Cursors.Default;
            
            // FIM DE TODOS OS SEGMENTOS!
            }


//------------------------- PROGRAMA FINAL - IDENTIFICAR MATRICULA------------------------

        private void identificarMatriculaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (img == null)
                return;
            Cursor = Cursors.WaitCursor;
            imgUndo = img.Copy();

            img_original = img.Copy();
            

            //1ª FASE DO CORTE, E RESPECTIVA ANALISE DE VALORES --------------------------
            // (APENAS CORTANDO A IMAGEM A PARTIR DOS LIMITES DE TRANSIÇÃO NAS PROJECÇOES DAS COLUNAS E
            //   

            //declarão das variáveis atribuidas às intensidade das projecções em x e y
            int[,] intensidades = ImageClass.Transicao(img, imgUndo, 0, 0); //busca a soma das intensidades de cada linha, e colunas
            int i; int[] vector_x = new int[img.Width]; int[] vector_y = new int[img.Height];

            for (i = 0; i < img.Height; i++)
            { { vector_y[i] = intensidades[1, i]; } }

            // declaração das variáveis para operações de limitar àrea à matricula
            int x_max, y_max = 0, maximo = 0, width = img.Width, height = img.Height;
            int lim_up = 0, lim_down = 0, lim_dir = 0, lim_esq = 0;

            // achar linha com intensidade máxima 
            for (i = 0; i < img.Height; i++)
            {
                if (vector_y[i] > maximo)
                {
                    maximo = vector_y[i];
                    y_max = i;
                }

            }

            //achar os limites superior e inferior da matricula
            for (i = y_max; i > 0; i--)
            {
                if (vector_y[i] < 25)
                {
                    lim_up = i;
                    break;
                }
            }
            for (i = y_max; i < img.Height; i++)
            {
                if (vector_y[i] < 25)
                {
                    lim_down = i;
                    break;
                }
            }
            // buscar o resultado da transicao ignorando o que está fora dos limites



            int[,] intensidades2 = ImageClass.Transicao(img, imgUndo, lim_up, lim_down);
                                  


            for (i = 0; i < img.Width; i++)
            {
                vector_x[i] = intensidades2[0, i];
            }

            x_max = 0;
            maximo = 0;
            for (i = (img.Width) / 3; i < (img.Width); i++)
            {
                if (vector_x[i] > maximo)
                {
                    maximo = vector_x[i];
                    x_max = i;
                }

            }
            //achar os limites direito e esquerdo da matricula
            int contador = 0;
            for (i = x_max; i > (img.Width) / 3; i--)
            {
                if (vector_x[i] < 1 && contador < 10)
                {
                    contador++;
                }
                else if (vector_x[i] < 1 && contador == 10)
                { lim_esq = i + 10; break; }
                else
                {
                    if (vector_x[i] > 1)
                    { contador = 0; }
                }


            }
            contador = 0;
            for (i = x_max; i < (img.Width); i++)
            {
                if (vector_x[i] < 1 && contador < 10)
                {
                    contador++;
                }
                else if (vector_x[i] < 1 && contador == 10)
                { lim_dir = i - 10; break; }
                else
                {
                    if (vector_x[i] > 1)
                    { contador = 0; }
                }
            }

            img = imgUndo.Copy(new Rectangle(lim_esq, lim_up, lim_dir - lim_esq, lim_down - lim_up));

            // 2ª FASE DE CORTE - FINALMENTE SEPARAR AS LETRAS

            ImageClass.Binarizacao(img, imgUndo, ImageClass.Otsu(img, imgUndo));


            int[,] escuros = ImageClass.graficoProjecções(img, imgUndo,1); // corta linhas desnecessárias
                   
            
            //declarão das variáveis atribuidas às intensidade das projecções em y
            int[] vector_y_letra = new int[img.Height];
            for (i = 0; i < img.Height; i++)
            { vector_y_letra[i] = escuros[1, i]; }             
                       
                      
            // OBTER E MOSTRAR A IMAGEM CORTADA (APENAS LINHAS QUE PERTENÇAM ÀS LETRAS) ------------------


            int y; contador = 0; int[] limites = new int[2];
            if (escuros[1, 0] == 1)
            {
                limites[0] = 0;
                contador++;
            }
            limites[1]=(img.Height)-1;
                    
            
            for (y=0; y<img.Height-1 ; y++ )
            {
                if (escuros[1, y] != escuros[1, y+1] && contador < 2)
                {
                    limites[contador] = (contador==1)?y+1:y;
                    contador++;  
                }

                if (contador>=2) break;
                
                    
            }

            img = img.Copy(new Rectangle(0,limites[0], img.Width, limites[1]-limites[0]+1));
            img_matricula = img.Copy();
            //---FIM DA 2ª FASE DE CORTE 

            //TIRA AS POSIÇÕES PARA CORTE DE LETRAS
            int [] vector_x_letra = new int[img.Width];
                
            int[,] escuros2 = ImageClass.graficoProjecções(img, imgUndo, 1);
            
            for (i = 0; i < img.Width; i++)
            { vector_x_letra[i] = escuros2[0, i]; }

           

            contador = 0; int valor, valor_ant=0,cont_lim=0;
            int[] limites_x_letra = new int[12];
            for (i = 0; i < img.Width; i++)
            {
                if (vector_x_letra[i] != 0)
                { valor = 1;
                if (i < img.Width - 2)
                    {
                        if (vector_x_letra[i + 1] == 0)
                        { valor = 0; }
                    }
                }
                else
                { valor = 0; }

                if (valor_ant != valor && cont_lim<4)
                {
                    limites_x_letra[contador] = (valor == 0) ? i - 1 : i;
                    contador++;
                    cont_lim++;
                    if (contador == 12) break;

                }
                else if (valor_ant != valor && cont_lim >= 4)
                {
                        if (cont_lim == 4)
                        { cont_lim++; }
                        else
                        { cont_lim = 0; }
                }
                
                valor_ant = valor;
            }

            BasedeDados.Items.Clear();
            //CORTA LETRAS E COMPARA COM A BASE DE DADOS
            int j = 0;
            int lim_dir_letra, lim_esq_letra; char letra_identif;
            for (i=0; i<6; i++)      // 6              
            {
                lim_dir_letra = limites_x_letra[j + 1];
                lim_esq_letra = limites_x_letra[j];

                img_letra_mtr = img.Copy(new Rectangle(lim_esq_letra, 0, lim_dir_letra - lim_esq_letra + 1, img.Height));
                        if (i==0){  pictureBox1.Image = img_letra_mtr.Bitmap;pictureBox1.Refresh();}
                        if (i==1){  pictureBox2.Image = img_letra_mtr.Bitmap;pictureBox2.Refresh();}
                        if (i==2){  pictureBox3.Image = img_letra_mtr.Bitmap;pictureBox3.Refresh();}
                        if (i==3){  pictureBox4.Image = img_letra_mtr.Bitmap;pictureBox4.Refresh();}
                        if (i==4){  pictureBox5.Image = img_letra_mtr.Bitmap;pictureBox5.Refresh();}
                        if (i==5){  pictureBox6.Image = img_letra_mtr.Bitmap;pictureBox6.Refresh();}
                        
                        img_letra_mtr=img_letra_mtr.Resize(12, 18, Emgu.CV.CvEnum.INTER.CV_INTER_AREA);
                  ImageClass.Binarizacao(img_letra_mtr, img_letra_mtr, ImageClass.Otsu(img_letra_mtr, imgUndo));      
                        j = j + 2;
                        letra_identif = ImageClass.ComparaLetras(img_letra_mtr, imgUndo);
                        BasedeDados.Items.Add(letra_identif);
                        if (i == 1 || i == 3)
                        { BasedeDados.Items.Add("-"); }
                      

                            }

            ImageClass.DelimitaMatriculaVerde(img_original, imgUndo, lim_esq, lim_dir, lim_up, lim_down);

            pictureBox7.Image = img_matricula.Bitmap;
            pictureBox7.Refresh();
            ImageApl.Image = img_original.Bitmap;
            ImageApl.Refresh();
            Cursor = Cursors.Default;

        }









//---------------CODIGO QUE NÃO INTERESSA-------------------------------------------------------------------------



        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            


        }

        private void Nextletter_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //BOTÃO
            //CORTAR LETRA E COMPARAR COM BASE DE DADOS
            
            //parte de comparar com base de dados
            //if (conta_obj != 3 && conta_obj != 5) // 3º e 5º objecto são os pregos da matricula
            {
                //ImageClass.Binarizacao(img, imgUndo, ImageClass.Otsu(img, imgUndo));
                //img_letra_mtr = img.Copy(new Rectangle(0, 0, img.Width, img.Height));
                //img_letra_mtr = img_letra_mtr.Resize(8, 12, Emgu.CV.CvEnum.INTER.CV_INTER_AREA);
                //char letra_identif = ImageClass.ComparaLetras(img, imgUndo);
                //BasedeDados.Items.Add(letra_identif);

             }
            img= img.Resize(4, 6, Emgu.CV.CvEnum.INTER.CV_INTER_AREA);
            
            
            

            
            
            
          // int[,] matriz = ImageClass.ComparaLetras(img, imgUndo);

            //int z, z_out = 0, valor_ant = matriz[0, 0];
            //for (z=1; z<34 ; z++)

            {   // if (matriz[0, z]<valor_ant)
                 //{valor_ant=matriz[0,z];
                // z_out=z;}
                //BasedeDados.Items.Add(matriz[0, z]);
             }
            // Matricula.Items.Add(matriz[0, z_out]);
            char[] charvector = {'A', 'B', 'C', 'D', 'E','F','G','H','I','J','K','L','M',
               'N','O','P','Q','R','S','T','U','V','X','Z','1','2','3','4','5','6','7','8','9','0'};

            String imgpath = null;

            //imgpath = "C:\\Documents and Settings\\Michael\\Ambiente de trabalho\\SS_OpenCV\\SS_OpenCV\\bin\\Debug\\Base Dados\\" + charvector[z_out] + ".bmp";
            //img1 = new Image<Bgr, byte>(imgpath);

             pictureBox1.Image = img1.Bitmap; pictureBox1.Refresh();
            
            
             

        }

        private void resizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            img_letra_mtr = img.Resize(4, 6, Emgu.CV.CvEnum.INTER.CV_INTER_AREA);
            { pictureBox1.Image = img_letra_mtr.Bitmap; pictureBox1.Refresh(); }

        }

        private void resize2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            img_letra_mtr = img.Resize(12, 18, Emgu.CV.CvEnum.INTER.CV_INTER_AREA);
            pictureBox2.Image = img_letra_mtr.Bitmap; pictureBox2.Refresh();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tiraLetrasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

       

       

       

        }


   


       
     

       


        
}