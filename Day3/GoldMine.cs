namespace Day3
{
    public class GoldMine
    {
        public int CountFieldsToRemove(string[] inputs, string part)
        {
            (int[,] fields, int numberOfFields) = ConvertFieldsToNumbersList(inputs);
            int sum = numberOfFields;
            int slope = 2;

            while (true)
            {
                int tmpCounter = 0;

                for (int row = 1; row < fields.GetLength(0) - 1; row++)
                {
                    for (int column = 1; column < fields.GetLength(1) - 1; column++)
                    {
                        int field = fields[row, column];

                        if (CanDig(field, fields[row - 1, column], slope) && CanDig(field, fields[row + 1, column], slope) && CanDig(field, fields[row, column - 1], slope) && CanDig(field, fields[row, column + 1], slope))
                        {
                            if (part.Equals("3"))
                            {
                                if (CanDig(field, fields[row - 1, column + 1], slope) && CanDig(field, fields[row - 1, column - 1], slope) && CanDig(field, fields[row + 1, column - 1], slope) && CanDig(field, fields[row + 1, column + 1], slope))
                                {
                                    fields[row, column] = slope;
                                    tmpCounter++;
                                }
                            }

                            else
                            {
                                fields[row, column] = slope;
                                tmpCounter++;
                            }
                        }
                    }
                }

                slope++;
                sum += tmpCounter;

                if (tmpCounter == 0)
                    break;
            }

            return sum;
        }

        private bool CanDig(int field, int fieldToCheck, int slope)
        {
            if (field > 0 && fieldToCheck == slope - 1 || fieldToCheck == slope)
                return true;

            return false;
        }

        private void PrintFileds(int[,] fields)
        {
            for (int i = 0; i < fields.GetLength(0); i++)
            {
                for (int j = 0; j < fields.GetLength(1); j++)
                {
                    Console.Write(fields[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("===========================NEW===========================");
        }

        private (int[,], int) ConvertFieldsToNumbersList(string[] inputs)
        {
            int[,] fields = new int[inputs.Length, inputs[^1].Length];
            int counter = 0;

            for (int i = 0; i < inputs.Length; i++)
            {
                for (int j = 0; j < inputs[i].Length; j++)
                {
                    if (inputs[i][j] == '.')
                        fields[i, j] = 0;
                    else
                    {
                        fields[i, j] = 1;
                        counter++;
                    }
                }
            }

            return (fields, counter);
        }
    }
}
