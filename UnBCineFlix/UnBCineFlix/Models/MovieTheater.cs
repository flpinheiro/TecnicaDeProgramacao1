using System.ComponentModel.DataAnnotations;
using System.Text;
using System;

namespace UnBCineFlix.Models
{
    /// <summary>
    /// Classe MovieTheater -> define uma sala de cinema
    /// </summary>
    public class MovieTheater
    {
        /// <summary>
        /// Id da sala de cinema no banco de dados
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Numero da sala de cinema
        /// </summary>
        [Required]
        public int Number { get; set; }

        private Chair[][] _chairs;
        /// <summary>
        /// Lista de cadeiras da sala de cinema
        /// </summary>
        public Chair[][] Chairs { get => _chairs; private set => _chairs = value; }
        /// <summary>
        /// Quantidade de fileiras que existe na sala
        /// </summary>
        [Required]
        public int QtdRow { get; }
        /// <summary>
        /// Quantidade de colunas que exste na sala
        /// </summary>
        [Required]
        public int QtdColumn { get; }
        /// <summary>
        /// Construtor padrão da sala de cinema
        /// </summary>
        /// <param name="qtdRow"></param>
        /// <param name="qtdColumn"></param>
        /// <param name="number">Numero da sala</param>
        /// <exception cref="ArgumentException">Lança se o argumento for igual ou menor que zero.</exception>
        /// 
        /// 
        public MovieTheater(int qtdRow, int qtdColumn, int number = 1)
        {
            if (qtdRow <=0 || qtdColumn <= 0||number <=0)
            {
                throw new ArgumentException("O número de fileiras ou de colunas não pode ser nulo ou negativo");
            }
            QtdColumn = qtdColumn;
            QtdRow = qtdRow;
            Number = number;
            //inicia a lista de cadeiras
            _chairs = new Chair[qtdRow][];
            for (int i = 0; i < qtdRow; i++)
            {
                _chairs[i] = new Chair[qtdColumn];
            }
        }

        /// <summary>
        /// Adiciona uma cadeira a sala de espetaculo
        /// </summary>
        /// <param name="chair"></param>
        /// <exception cref="ArgumentException">Lança essa exceção se a posicão da cadeira for maior do que a quantidade de colunas e fileiras da sala</exception>
        public void AddChair(Chair chair)
        {
            if (QtdColumn < chair.Column || QtdRow < chair.Row)
            {
                throw new ArgumentException("A sala não pode alocar essa cadeira");
            }
            _chairs[chair.Row][chair.Column] = chair;
        }
        /// <summary>
        /// Escreve na tela a configuração atual da sala, sendo
        /// |   | -> lugar sem cadeira
        /// |[ ]| -> cadeira livre para ser vendida
        /// |[-]| -> cadeira ocupaa, já vendida
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            var ret = new StringBuilder();
            ret.AppendLine($"Sala Número:{Number}");
            ret.Append("|   |");
            for (int j = 0; j < QtdColumn; j++)
            {
                if (j < 9)
                {
                    ret.Append($"|  {(j + 1)}  |");
                }
                else
                {
                    ret.Append($"| {(j+1)}  |");
                }
                
            }
            ret.AppendLine();
            for (int i = 0; i < QtdRow; i++)
            {
                ret.Append($"| {(char)(i + 65)} |");
                for (int j = 0; j < QtdColumn; j++)
                {
                    if (_chairs[i][j] == null)
                    {
                        ret.Append("|     |");
                    }
                    else
                    {
                        if (_chairs[i][j].Status)
                        {
                            ret.Append("|[---]|");
                        }
                        else
                        {
                            ret.Append("|[   ]|");
                        }
                    }
                }
                ret.AppendLine();

            }
            for (int i = 0; i < QtdColumn / 2; i++)
            {
                ret.Append("       ");
            }
            ret.Append("TELA");
            ret.AppendLine();
            return ret.ToString();
        }
    }
}
