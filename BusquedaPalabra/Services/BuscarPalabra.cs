using System.Reflection.Metadata.Ecma335;

namespace BusquedaPalabra.Services
{
    public class BuscarPalabra
    {
        public static bool ContieneNombre(string[] info, string nombre)
        {
            int filas = info.Length;
            int cols = info[0].Length;

            char[,] matriz = new char[filas, cols];
            for (int i = 0; i < filas; i++)
                for (int j = 0; j < cols; j++)
                    matriz[i, j] = info[i][j];

            int[][] direcciones = new int[][]
            {
                new int[] {0, 1},
                new int[] {1, 0},
                new int[] {1, 1},
                new int[] {-1, 1}
            };

            foreach (var dir in direcciones)
            {
                for (int i = 0; i < filas; i++)
                    for (int j = 0; j < cols; j++)
                        if (BuscarDesde(matriz, i, j, dir[0], dir[1], nombre))
                            return true;
            }

            return false;
        }

        private static bool BuscarDesde(char[,] matriz, int x, int y, int dx, int dy, string palabra)
        {
            for(int i = 0; i < palabra.Length; i++)
            {
                int nx = x + i * dx;
                int ny = y + i * dy;

                if(nx < 0 || ny < 0 || nx >= matriz.GetLength(0) || ny >= matriz.GetLength(1))
                {
                    return false;
                }

                if (matriz[nx, ny] != palabra[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
