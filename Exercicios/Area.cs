double a, b, c;
            double triangulo, circulo, trapezio, quadrado, retangulo;
            string linha;

            linha = Console.ReadLine();

            string[] vetor = linha.Split(' ');
            a = Convert.ToDouble(vetor[0]);
            b = Convert.ToDouble(vetor[1]);
            c = Convert.ToDouble(vetor[2]);

            triangulo = a * c / 2;
            circulo = 3.14159 * Math.Pow(c, 2);
            trapezio = ((a + b) / 2) * c;
            quadrado = Math.Pow(b, 2);
            retangulo = a * b;

            Console.WriteLine("TRIANGULO: {0}", triangulo.ToString("0.000"));
            Console.WriteLine("CIRCULO: {0}", circulo.ToString("0.000"));
            Console.WriteLine("TRAPEZIO: {0}", trapezio.ToString("0.000"));
            Console.WriteLine("QUADRADO: {0}", quadrado.ToString("0.000"));
            Console.WriteLine("RETANGULO: {0}", retangulo.ToString("0.000"));