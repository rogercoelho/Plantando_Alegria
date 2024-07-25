using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plantando_Alegria.Utils
{
    public class ResizeImages
    {
        public Bitmap ResizeImage(Image image, int width, int height)
        {
            /* Funcao -> Metodo que faz o redimensionamento da imagem e converte em png. O metodo faz
             * o processamento da imagem retornando para a variavel image (System/Drawing) no tamanho 
             * de largura e altura (Int)  */

            var destRect = new Rectangle(0, 0, width, height);
            var destImagem = new Bitmap(width, height);
            destImagem.SetResolution(image.HorizontalResolution, image.VerticalResolution);
            using (var graphics = Graphics.FromImage(destImagem))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }
            return destImagem;
        }
    }
}
