using System;
using System.Collections.Generic;
using System.Text;
using Emgu.CV.Structure;
using Emgu.CV;
using System.Windows.Forms;

namespace SS_OpenCV
{
    class ImageClass
    {


        /// <summary>
        /// Conversão para Cinzento
        /// </summary>
        /// <param name="img">imagem</param>
        /// <param name="imgUndo">Cópia da Imagem</param>
        internal static void ConvertToGray(Image<Bgr, byte> img)
        {
            unsafe
            {
                // acesso directo à memoria da imagem (sequencial)
                // direcção top left -> bottom right

                MIplImage m = img.MIplImage;
                byte* dataPtr = (byte*)m.imageData.ToPointer();
                byte blue, green, red, gray;
                int width = img.Width;
                int height = img.Height;
                int nChan = m.nChannels; // numero de canais 3
                int padding = m.widthStep - m.nChannels * m.width; // alinhamento (padding)
                int x, y;

                if (nChan == 3) // imagem em RGB
                {
                    for (y = 0; y < height; y++)
                    {
                        for (x = 0; x < width; x++)
                        {
                            //obtém as 3 componentes
                            blue = dataPtr[0];
                            green = dataPtr[1];
                            red = dataPtr[2];

                            // converte para cinza
                            gray = (byte)(((int)blue + green + red) / 3);

                            // guarda na imagem
                            dataPtr[0] = gray;
                            dataPtr[1] = gray;
                            dataPtr[2] = gray;

                            // avança apontador para próximo pixel
                            dataPtr += nChan;
                        }

                        //no fim da linha avança alinhamento (padding)
                        dataPtr += padding;
                    }
                }
            }
        }


        /// <summary>
        /// Negativo da Imagem
        /// Algoritmo de manipulação de imagem mais lento
        /// </summary>
        /// <param name="img">Imagem</param>
        internal static void Negative(Image<Bgr, byte> img)
        {
            Bgr aux;
            for (int y = 0; y < img.Height; y++)
            {
                for (int x = 0; x < img.Width; x++)
                {
                    // acesso directo : mais lento 
                    aux = img[y, x];
                    img[y, x] = new Bgr(255 - aux.Blue, 255 - aux.Green, 255 - aux.Red);
                }
            }
        }


        internal static void Negative2(Image<Bgr, byte> img)
        {
            unsafe
            {
                // acesso directo à memoria da imagem (sequencial)
                // direcção top left -> bottom right

                MIplImage m = img.MIplImage;
                byte* dataPtr = (byte*)m.imageData.ToPointer();
                byte blue, green, red, gray;
                int width = img.Width;
                int height = img.Height;
                int nChan = m.nChannels; // numero de canais 3
                int padding = m.widthStep - m.nChannels * m.width; // alinhamento (padding)
                int x, y;

                if (nChan == 3) // imagem em RGB
                {
                    for (y = 0; y < height; y++)
                    {
                        for (x = 0; x < width; x++)
                        {
                            //obtém as 3 componentes
                            blue = dataPtr[0];
                            green = dataPtr[1];
                            red = dataPtr[2];

                            blue = (byte)(255 - blue);
                            green = (byte)(255 - green);
                            red = (byte)(255 - red);


                            // converte para cinza
                            gray = (byte)(((int)blue + green + red) / 3);

                            // guarda na imagem
                            dataPtr[0] = blue;
                            dataPtr[1] = green;
                            dataPtr[2] = red;

                            // avança apontador para próximo pixel
                            dataPtr += nChan;
                        }

                        //no fim da linha avança alinhamento (padding)
                        dataPtr += padding;
                    }
                }
            }
        }

        internal static void translacao(Image<Bgr, byte> img,
            Image<Bgr, byte> imgUndo, int dx, int dy)
        {
            unsafe
            {
                // acesso directo à memoria da imagem (sequencial)
                // direcção top left -> bottom right

                MIplImage m = img.MIplImage;
                byte* dataPtr = (byte*)m.imageData.ToPointer();

                MIplImage mO = imgUndo.MIplImage;
                byte* dataPtrO = (byte*)mO.imageData.ToPointer();

                int width = img.Width;
                int height = img.Height;
                int nChan = m.nChannels; // numero de canais 3
                int widthstep = m.widthStep;
                int padding = m.widthStep - m.nChannels * m.width; // alinhamento (padding)
                int x, y, xd, yd;

                if (nChan == 3) // imagem em RGB
                {
                    for (y = 0; y < height; y++)
                    {
                        for (x = 0; x < width; x++)
                        {
                            xd = x - dx;
                            yd = y - dy;

                            if (xd >= 0 && xd < width && yd >= 0 && yd < height)
                            {
                                dataPtr[0] = (dataPtrO + xd * nChan + yd * widthstep)[0];
                                dataPtr[1] = (dataPtrO + xd * nChan + yd * widthstep)[1];
                                dataPtr[2] = (dataPtrO + xd * nChan + yd * widthstep)[2];
                            }
                            else
                            {
                                dataPtr[0] = 0;
                                dataPtr[1] = 0;
                                dataPtr[2] = 0;

                            }


                            // avança apontador para próximo pixel
                            dataPtr += nChan;
                        }

                        //no fim da linha avança alinhamento (padding)
                        dataPtr += padding;
                    }
                }
            }
        }





        internal static void rotationInverse(Image<Bgr, byte> img, Image<Bgr, byte> imgUndo, double ang0)
        {
            unsafe
            {
                // acesso directo à memoria da imagem (sequencial)
                // direcção top left -> bottom right

                MIplImage m = img.MIplImage;
                byte* dataPtr = (byte*)m.imageData.ToPointer();

                MIplImage mO = imgUndo.MIplImage;
                byte* dataPtrO = (byte*)mO.imageData.ToPointer();
                
                int width = img.Width;
                int height = img.Height;
                int nChan = m.nChannels; // numero de canais 3
                int widthstep = m.widthStep;
                int padding = m.widthStep - m.nChannels * m.width; // alinhamento (padding)
                double x, y, xnew_ref, ynew_ref;
                double ang = (ang0 * Math.PI) / 180;
                double cos = Math.Cos(ang);
                double sen = Math.Sin(ang);
                double cx = height / 2;
                double cy = width / 2;

                if (nChan == 3) // imagem em RGB
                {
                    for (y = 0; y < height; y++)
                    {
                        for (x = 0; x < width; x++)
                        {
                            xnew_ref = Math.Round((x - cy) * cos - (cx - y) * sen + cy);
                            ynew_ref = Math.Round(cx - (x - cy) * sen - (cx - y) * cos);

                            if (xnew_ref >= 0 && xnew_ref < width && ynew_ref >= 0 && ynew_ref < height)
                            {
                                dataPtr[0] = (dataPtrO + (int)xnew_ref * nChan + (int)ynew_ref * widthstep)[0];
                                dataPtr[1] = (dataPtrO + (int)xnew_ref * nChan + (int)ynew_ref * widthstep)[1];
                                dataPtr[2] = (dataPtrO + (int)xnew_ref * nChan + (int)ynew_ref * widthstep)[2];
                            }
                            else
                            {
                                dataPtr[0] = 0;
                                dataPtr[1] = 0;
                                dataPtr[2] = 0;

                            }


                            // avança apontador para próximo pixel
                            dataPtr += nChan;
                        }

                        //no fim da linha avança alinhamento (padding)
                        dataPtr += padding;
                    }
                }
            }
        }

        internal static void media(Image<Bgr, byte> img, Image<Bgr, byte> imgUndo)
        {
            unsafe
            {
                // acesso directo à memoria da imagem (sequencial)
                // direcção top left -> bottom right

                MIplImage m = img.MIplImage;
                byte* dataPtr = (byte*)m.imageData.ToPointer();
                MIplImage m2 = imgUndo.MIplImage;
                byte* dataPtr2 = (byte*)m2.imageData.ToPointer();
                int width = img.Width;
                int height = img.Height;
                int nChan = m.nChannels; // numero de canais 3
                int padding = m.widthStep - m.nChannels * m.width; // alinhamento (padding)
                double x, y;
                int widthStep = m.widthStep;
                double somaB, somaG, somaR;

                dataPtr += widthStep + nChan;
                dataPtr2 += widthStep + nChan;

                for (y = 1; y < (height - 1); y++)
                {
                    for (x = 1; x < (width - 1); x++)
                    {
                        somaB = dataPtr2[0] + dataPtr2[-3] + dataPtr2[3] +
                            dataPtr2[-widthStep] + dataPtr2[-3 - widthStep] + dataPtr2[3 - widthStep] +
                            dataPtr2[0 + widthStep] + dataPtr2[-3 + widthStep] + dataPtr2[3 + widthStep];

                        somaG = dataPtr2[1] + dataPtr2[-4] + dataPtr2[4] + dataPtr2[1 - widthStep] + dataPtr2[-4 - widthStep] +
                            dataPtr2[4 - widthStep] + dataPtr2[1 + widthStep] + dataPtr2[-4 + widthStep] +
                            dataPtr2[4 + widthStep];

                        somaR = dataPtr2[2] + dataPtr2[-5] + dataPtr2[5] + dataPtr2[2 - widthStep] + dataPtr2[-5 - widthStep] +
                            dataPtr2[5 - widthStep] + dataPtr2[2 + widthStep] + dataPtr2[-5 + widthStep] +
                            dataPtr2[5 + widthStep];


                        dataPtr[0] = (byte)(somaB / 9);
                        dataPtr[1] = (byte)(somaG / 9);
                        dataPtr[2] = (byte)(somaR / 9);



                        // avança apontador para próximo pixel
                        dataPtr += nChan;
                        dataPtr2 += nChan;

                    }   //no fim da linha avança alinhamento (padding)
                    dataPtr += padding + 2 * nChan;
                    dataPtr2 += padding + 2 * nChan;
                }
            }
        }



        internal static void media_ponderada(Image<Bgr, byte> img, Image<Bgr, byte> imgUndo, int c11, int c12, int c13, int c21, int c22, int c23, int c31, int c32, int c33, int peso)
        {
            unsafe
            {
                // acesso directo à memoria da imagem (sequencial)
                // direcção top left -> bottom right

                MIplImage m = img.MIplImage;
                byte* dataPtr = (byte*)m.imageData.ToPointer();
                MIplImage m2 = imgUndo.MIplImage;
                byte* dataPtr2 = (byte*)m2.imageData.ToPointer();
                int width = img.Width;
                int height = img.Height;
                int nChan = m.nChannels; // numero de canais 3
                int padding = m.widthStep - m.nChannels * m.width; // alinhamento (padding)
                double x, y;//, c11,c12,c13,c21,c22,c23,c31,c32,c33, peso;
                int widthStep = m.widthStep;
                double somaB, somaG, somaR;



                dataPtr += widthStep + nChan;
                dataPtr2 += widthStep + nChan;

                for (y = 1; y < (height - 1); y++)
                {
                    for (x = 1; x < (width - 1); x++)
                    {
                        somaB = c22 * dataPtr2[0] + c21 * dataPtr2[-3] + c23 * dataPtr2[3] +
                               c12 * dataPtr2[-widthStep] + c11 * dataPtr2[-3 - widthStep] + c13 * dataPtr2[3 - widthStep] +
                               c32 * dataPtr2[0 + widthStep] + c31 * dataPtr2[-3 + widthStep] + c33 * dataPtr2[3 + widthStep];

                        somaG = c22 * dataPtr2[1] + c21 * dataPtr2[-2] + c23 * dataPtr2[4] + c12 * dataPtr2[1 - widthStep]
                            + c11 * dataPtr2[-2 - widthStep] + c13 * dataPtr2[4 - widthStep] + c32 * dataPtr2[1 + widthStep]
                            + c31 * dataPtr2[-2 + widthStep] + c33 * dataPtr2[4 + widthStep];

                        somaR = c22 * dataPtr2[2] + c21 * dataPtr2[-1] + c23 * dataPtr2[5] + c12 * dataPtr2[2 - widthStep]
                            + c11 * dataPtr2[-1 - widthStep] + c13 * dataPtr2[5 - widthStep] + c32 * dataPtr2[2 + widthStep]
                            + c31 * dataPtr2[-1 + widthStep] + c33 * dataPtr2[5 + widthStep];




                        dataPtr[0] = (byte)(somaB / peso);
                        dataPtr[1] = (byte)(somaG / peso);
                        dataPtr[2] = (byte)(somaR / peso);



                        // avança apontador para próximo pixel
                        dataPtr += nChan;
                        dataPtr2 += nChan;

                    }   //no fim da linha avança alinhamento (padding)
                    dataPtr += padding + 2 * nChan;
                    dataPtr2 += padding + 2 * nChan;
                }
            }
        }



        internal static void Sobel(Image<Bgr, byte> img, Image<Bgr, byte> imgUndo)
        {
            unsafe
            {
                // acesso directo à memoria da imagem (sequencial)
                // direcção top left -> bottom right

                MIplImage m = img.MIplImage;
                byte* dataPtr = (byte*)m.imageData.ToPointer();
                MIplImage m2 = imgUndo.MIplImage;
                byte* dataPtr2 = (byte*)m2.imageData.ToPointer();
                int width = img.Width;
                int height = img.Height;
                int nChan = m.nChannels; // numero de canais 3
                int padding = m.widthStep - m.nChannels * m.width; // alinhamento (padding)
                double x, y;//, c11,c12,c13,c21,c22,c23,c31,c32,c33, peso;
                int widthStep = m.widthStep;
                double somaB, somaG, somaR, somaBx, somaGx, somaRx, somaBy, somaGy, somaRy;



                dataPtr += widthStep + nChan;
                dataPtr2 += widthStep + nChan;

                for (y = 1; y < (height - 1); y++)
                {
                    for (x = 1; x < (width - 1); x++)
                    {
                        somaBx = 0 * dataPtr2[0] + 2 * dataPtr2[-3] - 2 * dataPtr2[3] +
                           0 * dataPtr2[-widthStep] + 1 * dataPtr2[-3 - widthStep] - 1 * dataPtr2[3 - widthStep] +
                           0 * dataPtr2[0 + widthStep] + 1 * dataPtr2[-3 + widthStep] - 1 * dataPtr2[3 + widthStep];

                        somaGx = 0 * dataPtr2[1] + 2 * dataPtr2[-2] - 2 * dataPtr2[4] + 0 * dataPtr2[1 - widthStep]
                            + 1 * dataPtr2[-2 - widthStep] - 1 * dataPtr2[4 - widthStep] + 0 * dataPtr2[1 + widthStep]
                            + 1 * dataPtr2[-2 + widthStep] - 1 * dataPtr2[4 + widthStep];

                        somaRx = 0 * dataPtr2[2] + 2 * dataPtr2[-1] - 2 * dataPtr2[5] + 0 * dataPtr2[2 - widthStep]
                            + 1 * dataPtr2[-1 - widthStep] - 1 * dataPtr2[5 - widthStep] + 0 * dataPtr2[2 + widthStep]
                            + 1 * dataPtr2[-1 + widthStep] - 1 * dataPtr2[5 + widthStep];


                        somaBy = 0 * dataPtr2[0] + 0 * dataPtr2[-3] + 0 * dataPtr2[3] -
                            2 * dataPtr2[-widthStep] - 1 * dataPtr2[-3 - widthStep] - 1 * dataPtr2[3 - widthStep] +
                            2 * dataPtr2[0 + widthStep] + 1 * dataPtr2[-3 + widthStep] + 1 * dataPtr2[3 + widthStep];

                        somaGy = 0 * dataPtr2[1] + 0 * dataPtr2[-2] + 0 * dataPtr2[4] - 2 * dataPtr2[1 - widthStep]
                            - 1 * dataPtr2[-2 - widthStep] - 1 * dataPtr2[4 - widthStep] + 2 * dataPtr2[1 + widthStep]
                            + 1 * dataPtr2[-2 + widthStep] + 1 * dataPtr2[4 + widthStep];

                        somaRy = 0 * dataPtr2[2] + 0 * dataPtr2[-1] + 0 * dataPtr2[5] - 2 * dataPtr2[2 - widthStep]
                            - 1 * dataPtr2[-1 - widthStep] - 1 * dataPtr2[5 - widthStep] + 2 * dataPtr2[2 + widthStep]
                            + 1 * dataPtr2[-1 + widthStep] + 1 * dataPtr2[5 + widthStep];

                        somaB = Math.Abs(somaBx) + Math.Abs(somaBy);
                        somaG = Math.Abs(somaGx) + Math.Abs(somaGy);
                        somaR = Math.Abs(somaRx) + Math.Abs(somaRy);

                        dataPtr[0] = (byte)(somaB);
                        dataPtr[1] = (byte)(somaG);
                        dataPtr[2] = (byte)(somaR);



                        // avança apontador para próximo pixel
                        dataPtr += nChan;
                        dataPtr2 += nChan;

                    }   //no fim da linha avança alinhamento (padding)
                    dataPtr += padding + 2 * nChan;
                    dataPtr2 += padding + 2 * nChan;
                }
            }
        }

        internal static int[] Histograma(Image<Bgr, byte> img, Image<Bgr, byte> imgUndo)
        {
            unsafe
            {
                // acesso directo à memoria da imagem (sequencial)
                // direcção top left -> bottom right

                MIplImage m = img.MIplImage;
                byte* dataPtr = (byte*)m.imageData.ToPointer();
                byte blue, green, red, gray;
                int width = img.Width;
                int height = img.Height;
                int nChan = m.nChannels; // numero de canais 3
                int padding = m.widthStep - m.nChannels * m.width; // alinhamento (padding)
                int x, y, i;
                int[] intensidades = new int[256];
                for (i = 0; i < 256; i++)
                {
                    intensidades[i] = 0;
                }

                if (nChan == 3) // imagem em RGB
                {
                    for (y = 0; y < height; y++)
                    {
                        for (x = 0; x < width; x++)
                        {
                            //obtém as 3 componentes
                            blue = dataPtr[0];
                            green = dataPtr[1];
                            red = dataPtr[2];

                            // converte para cinza
                            gray = (byte)(((int)blue + green + red) / 3);
                            intensidades[gray]++;


                            // avança apontador para próximo pixel
                            dataPtr += nChan;
                        }

                        //no fim da linha avança alinhamento (padding)
                        dataPtr += padding;
                    }
                }
                return intensidades;
            }

        }

        internal static void Binarizacao(Image<Bgr, byte> img, Image<Bgr, byte> imgUndo, int parametro)
        {
            unsafe
            {
                // acesso directo à memoria da imagem (sequencial)
                // direcção top left -> bottom right

                MIplImage m = img.MIplImage;
                byte* dataPtr = (byte*)m.imageData.ToPointer();
                byte blue, green, red, gray;
                int width = img.Width;
                int height = img.Height;
                int nChan = m.nChannels; // numero de canais 3
                int padding = m.widthStep - m.nChannels * m.width; // alinhamento (padding)
                int x, y;

                if (nChan == 3) // imagem em RGB
                {
                    for (y = 0; y < height; y++)
                    {
                        for (x = 0; x < width; x++)
                        {
                            //obtém as 3 componentes
                            blue = dataPtr[0];
                            green = dataPtr[1];
                            red = dataPtr[2];

                            // converte para cinza
                            gray = (byte)(((int)blue + green + red) / 3);
                            if (gray > parametro)
                            {
                                dataPtr[0] = 255;
                                dataPtr[1] = 255;
                                dataPtr[2] = 255;
                            }
                            else
                            {
                                dataPtr[0] = 0;
                                dataPtr[1] = 0;
                                dataPtr[2] = 0;
                            }
                            // avança apontador para próximo pixel
                            dataPtr += nChan;
                        }

                        //no fim da linha avança alinhamento (padding)
                        dataPtr += padding;
                    }
                }

            }

        }

        internal static int Otsu(Image<Bgr, byte> img, Image<Bgr, byte> imgUndo)
        {
            unsafe
            {
                // acesso directo à memoria da imagem (sequencial)
                // direcção top left -> bottom right

                MIplImage m = img.MIplImage;
                byte* dataPtr = (byte*)m.imageData.ToPointer();
                byte blue, green, red, gray;
                int width = img.Width;
                int height = img.Height;
                int nChan = m.nChannels; // numero de canais 3
                int padding = m.widthStep - m.nChannels * m.width; // alinhamento (padding)
                int x, y, i, j, k, size, t = 0;
                double q1, q2, u1, u2, expressao;
                int[] v = new int[256];
                size = 0; expressao = 0;
                for (i = 0; i < 256; i++)
                { v[i] = 0; }


                if (nChan == 3) // imagem em RGB
                {

                    for (y = 0; y < height; y++)
                    {
                        for (x = 0; x < width; x++)
                        { //obtém as 3 componentes
                            blue = dataPtr[0];
                            green = dataPtr[1];

                            red = dataPtr[2];

                            // converte para cinza
                            gray = (byte)(((int)blue + green + red) / 3);
                            v[gray]++;

                            size = size + 1;
                            // avança apontador para próximo pixel
                            dataPtr += nChan;
                        }


                        //no fim da linha avança alinhamento (padding)
                        dataPtr += padding;
                    }

                    for (j = 0; j < 256; j++)
                    {
                        q1 = 0; q2 = 0; u1 = 0; u2 = 0;
                        for (i = 0; i < j; i++)
                        {
                            q1 = q1 + (v[i] / ((float)size));
                            u1 = u1 + i * (v[i] / ((float)size));
                        }
                        for (k = j; k < 256; k++)
                        {
                            q2 = q2 + (v[k] / ((float)size));

                            u2 = u2 + k * (v[k] / ((float)size));
                        }

                        if (q1 > 0)
                        { u1 = u1 / q1; }
                        if (q2 > 0)
                        { u2 = u2 / q2; }
                        if (expressao < (q1 * q2 * Math.Pow((u1 - u2), 2)))
                        {
                            t = j;
                            expressao = (q1 * q2 * Math.Pow((u1 - u2), 2));
                        }
                    }

                }
                return t;


            }
        }
        // TRANSIÇÃO 
        internal static int[,] Transicao(Image<Bgr, byte> img, Image<Bgr, byte> imgUndo, int lim_sup, int lim_inf)
        {
            unsafe
            {
                // acesso directo à memoria da imagem (sequencial)
                // direcção top left -> bottom right

                MIplImage m = img.MIplImage;
                byte* dataPtr = (byte*)m.imageData.ToPointer();

                MIplImage m2 = imgUndo.MIplImage;
                byte* dataPtr2 = (byte*)m2.imageData.ToPointer();

                byte blue, green, red, gray;
                int width = img.Width;
                int height = img.Height;
                int nChan = m.nChannels; // numero de canais 3
                int padding = m.widthStep - m.nChannels * m.width; // alinhamento (padding)
                int x, y, dif;
                int[,] intensidades = new int[2, Math.Max(width, height)];
                for (y = 0; y < Math.Max(width, height); y++)
                {
                    intensidades[0, y] = 0;
                    intensidades[1, y] = 0;
                }


                if (nChan == 3) // imagem em RGB
                {
                    for (y = 0; y < height; y++)
                    {
                        for (x = 0; x < width; x++)
                        {
                            dataPtr[0] = (byte)(Math.Abs(-1 * dataPtr2[-3] + dataPtr2[3]));
                            dataPtr[1] = (byte)(Math.Abs(-1 * dataPtr2[-2] + dataPtr2[4]));
                            dataPtr[2] = (byte)(Math.Abs(-1 * dataPtr2[-1] + dataPtr2[5]));

                            //obtém as 3 componentes
                            blue = dataPtr[0];
                            green = dataPtr[1];
                            red = dataPtr[2];

                            dif = (Math.Abs(blue - red) + Math.Abs(blue - green) + Math.Abs(red - green));
                            // converte para cinza
                            gray = (byte)(((int)blue + green + red) / 3);

                            if (gray > 51 && dif < 20)
                            {
                                dataPtr[0] = 255;
                                dataPtr[1] = 255;
                                dataPtr[2] = 255;
                                if (y > lim_sup && y < lim_inf && x > width / 3)
                                {
                                
                                    intensidades[0, x]++;}
                                
                                    intensidades[1, y] ++ ; }
                            else
                            {
                                dataPtr[0] = 0;
                                dataPtr[1] = 0;
                                dataPtr[2] = 0;
                            }
                            // avança apontador para próximo pixel
                            dataPtr += nChan;
                            dataPtr2 += nChan;


                        }

                        //no fim da linha avança alinhamento (padding)
                        dataPtr += padding;
                        dataPtr2 += padding;

                    }
                }
                return intensidades;


            }

        }
     
        // COMPARA LETRAS
        internal static char ComparaLetras(Image<Bgr, byte> img, Image<Bgr, byte> imgUndo)
        //internal static int[,] ComparaLetras(Image<Bgr, byte> img, Image<Bgr, byte> imgUndo)
        {
            unsafe
            {
                // acesso directo à memoria da imagem (sequencial)
                // direcção top left -> bottom right

                MIplImage m = img.MIplImage;
                byte* dataPtr = (byte*)m.imageData.ToPointer();
                //MIplImage m1 = img1.MIplImage;
                //byte* dataPtr1 = (byte*)m1.imageData.ToPointer();
                byte* dataPtr1 = null;
                int width = img.Width;
                int height = img.Height;
                int nChan = m.nChannels; // numero de canais 3
                int padding = m.widthStep - m.nChannels * m.width; // alinhamento (padding)
                int x, y; 
                int dif_actual,dif_ant=(3*755)*height*width, match_actual, match_ant = 0 ;
                int z,match_max=0;
                Image<Bgr, byte> img1BD = null;
                char letra_identif = 'A';
               // char[] charvector = {'A', 'X', '1', '3', '9' };
                char[] charvector = {'A', 'B', 'C', 'D', 'E','F','G','H','I','J','K','L','M',
               'N','O','P','Q','R','S','T','U','V','X','Z','1','2','3','4','5','6','7','8','9','0'};
                String imgpath = null;
                int[,] matriz_pixeis = new int[2, 34]; int i=0;
                
                int [,] matriz_imagem= new int[2,34];
                //for(z=0; z<5; z++)
                for (z = 0; z < 34; z++) //34
                {
                    imgpath = Application.StartupPath+ "\\Base Dados\\" + charvector[z] + ".bmp";
                    img1BD = new Image<Bgr, byte>(imgpath);
                    
                    img1BD=img1BD.Resize(12, 18, Emgu.CV.CvEnum.INTER.CV_INTER_AREA);
                    ImageClass.Binarizacao(img1BD, img1BD, ImageClass.Otsu(img1BD, imgUndo));
                    MIplImage img1 = img1BD.MIplImage;
                   
                    dataPtr1 = (byte*)img1.imageData.ToPointer();
                    dataPtr = (byte*)m.imageData.ToPointer();
                    //match_actual=(img.Width*img.Height);
                    match_actual = 0;
                    dif_actual = 0;

                    //new ShowImgForm(img, img1BD.Cmp(img, Emgu.CV.CvEnum.CMP_TYPE.CV_CMP_EQ),img1BD).ShowDialog();
                    if (nChan == 3) // imagem em RGB
                    {



                        for (y = 0; y < height; y++)
                        {

                            for (x = 0; x < width; x++)
                            {
                                if ((dataPtr[0] == dataPtr1[0]) && (dataPtr[1] == dataPtr1[1]) && (dataPtr[2] == dataPtr1[2]))
                                //if (Math.Abs((dataPtr[0]+dataPtr[1]+dataPtr[2])-(dataPtr1[0]+dataPtr1[1]+dataPtr1[3]))<5)
                                { match_actual++; }
                                //dif2 = Math.Abs((dataPtr[3] + dataPtr[4] + dataPtr[5]) - (dataPtr1[0] + dataPtr1[1] + dataPtr1[3]));
                                //dif_actual=dif_actual+dif;

                                //if (dif1<=dif2)
                                //  if((dataPtr[0]+dataPtr[1]+dataPtr[2])==(dataPtr1[0]+dataPtr1[1]+dataPtr1[3]))
                                //     {match_actual++;}   

                                //matriz_pixeis[0,i]=dataPtr[0]+dataPtr[1]+dataPtr[2];
                                //matriz_pixeis[1,i]=dataPtr1[0]+dataPtr1[1]+dataPtr1[2];
                                i++;

                                // avança apontador para próximo pixel
                                dataPtr += nChan;
                                dataPtr1 += nChan;
                            }


                            //no fim da linha avança alinhamento (padding)
                            dataPtr += padding;
                            dataPtr1 += img1.widthStep - img1.nChannels * img1.width;
                        }
                    } 
                    //matriz_pixeis[0, z] = dif_actual;
                    
                    //if (dif_actual<dif_ant) 
                    //height*width
                    if (match_actual > match_max)//29
                    { letra_identif = charvector[z];
                    match_max = match_actual;
                    }
                    match_ant = match_actual;
                      
                    dif_ant = dif_actual;

                } //return matriz_pixeis;
                return letra_identif;
                
            }
        }

    //   GRAFICOS DAS PROJECÇÕES
    

    internal static int[,] graficoProjecções(Image<Bgr, byte> img, Image<Bgr, byte> imgUndo, int corte) 
    // corte = 0 (ou qualquer outro número) -> não efectua corte ; corte = 1 -> efectua corte nas linhas que não correspondem à das letras
    {
        unsafe
        {
            // acesso directo à memoria da imagem (sequencial)
            // direcção top left -> bottom right

            MIplImage m = img.MIplImage;
            byte* dataPtr = (byte*)m.imageData.ToPointer();
            byte blue;
            int width = img.Width;
            int height = img.Height;
            int nChan = m.nChannels; // numero de canais 3
            int padding = m.widthStep - m.nChannels * m.width; // alinhamento (padding)
            int x, y, contador, valor_ant=0;
            int[,] escuros = new int[2, Math.Max(width, height)];
            for (y = 0; y < Math.Max(width, height); y++)
            {
                escuros[0, y] = 0;
                escuros[1, y] = 0;
            }


            if (nChan == 3) // imagem em RGB
            {
                for (y = 0; y < height; y++)
                {
                    contador = 0;
                    for (x = 0; x < width; x++)
                    {
                        //obtém as 3 componentes
                        blue = dataPtr[0];

                        if (blue == 0)
                        {
                           
                            escuros[0, x]++;
                            escuros[1, y]++;
                            valor_ant = 1;
                        }
                        else
                        {
                            if (valor_ant == 1)
                            { contador++; }
                            valor_ant = 0;
                        }

                        // avança apontador para próximo pixel
                        dataPtr += nChan;
                    }

                    //no fim da linha avança alinhamento (padding)
                    dataPtr += padding;
                    if (corte == 1)
                    {
                        if (contador < 6 || escuros[1, y] == height)
                        { escuros[1, y] = 0; }
                        else
                        { escuros[1, y] = 1; }
                    }                    
                }
            } return escuros;

        }
    }





    internal static void DelimitaMatriculaVerde(Image<Bgr, byte> img_original, Image<Bgr, byte> imgUndo, int lim_esq, int lim_dir, int lim_up, int lim_down)
    {
        unsafe
        {
            // acesso directo à memoria da imagem (sequencial)
            // direcção top left -> bottom right

            MIplImage m = img_original.MIplImage;
            byte* dataPtr = (byte*)m.imageData.ToPointer();

            MIplImage mO = imgUndo.MIplImage;
            byte* dataPtrO = (byte*)mO.imageData.ToPointer();

            int width = img_original.Width;
            int height = img_original.Height;
            int nChan = m.nChannels; // numero de canais 3
            int widthstep = m.widthStep;
            int padding = m.widthStep - m.nChannels * m.width; // alinhamento (padding)
            int x, y, xd, yd;

            if (nChan == 3) // imagem em RGB
            {
                for (y = 0; y < height; y++)
                {
                    for (x = 0; x < width; x++)
                    {


                        if (((x >= lim_esq && x <= lim_dir) && ((y >= lim_up - (height / 100) && y < lim_up) || (y > lim_down && y <= lim_down + (height / 100)))) || (((x >= lim_esq - (width / 100) && x < lim_esq) || (x > lim_dir && x <= lim_dir + (width / 100))) && (y >= lim_up - (height / 100) && y <= (lim_down)+(height / 100))))
                        {
                            dataPtr[0] = 0;
                            dataPtr[1] = 255;
                            dataPtr[2] = 0;
                        }
                      

                        // avança apontador para próximo pixel
                        dataPtr += nChan;
                    }

                    //no fim da linha avança alinhamento (padding)
                    dataPtr += padding;
                }
            }
        }
    }
    }
    
}

