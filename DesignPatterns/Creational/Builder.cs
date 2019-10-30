namespace DesignPatterns.Creational
{
    namespace Builder
    {
        class ClientApplication
        {
            public ClientApplication()
            {
                var director = new Director();

                //Create actual sports car
                var carBuilder = new CarBuilder();
                director.SetBuilder(carBuilder);
                director.ConstructSportsCar();
                var car = carBuilder.GetCar();

                //Create toy SUV car
                var toyBuilder = new ToyCarBuilder();
                director.SetBuilder(carBuilder);
                director.ConstructSUV();
                var toyCar = toyBuilder.GetToyCar();
            }
        }

        struct Car
        {
            public string Name { get; set; }
            public string Model { get; set; }
            public string Engine { get; set; }
        }

        struct ToyCar
        {
            public string Name { get; set; }
            public string Content { get; set; }
            public string Engine { get; set; }
        }

        interface IBuilder
        {
            void Reset();
            void SetBranding(string name, string model);
            void SetEngine(string name);
        }

        class CarBuilder : IBuilder
        {
            private Car car;

            public void Reset()
            {
                car = new Car();
            }

            public void SetBranding(string name, string model)
            {
                car.Name = name;
                car.Model = model;
            }

            public void SetEngine(string engine)
            {
                car.Engine = engine;
            }

            public Car GetCar()
            {
                return car;
            }
        }

        class ToyCarBuilder : IBuilder
        {
            private ToyCar toyCar;

            public void Reset()
            {
                toyCar = new ToyCar();
            }

            public void SetBranding(string name, string model)
            {
                toyCar.Name = name;
                toyCar.Content = model;
            }

            public void SetEngine(string engine)
            {
                toyCar.Engine = engine;
            }

            public ToyCar GetToyCar()
            {
                return toyCar;
            }
        }

        class Director
        {
            private IBuilder builder;

            public void SetBuilder(IBuilder builder)
            {
                this.builder = builder;
            }

            public void ConstructSportsCar()
            {
                builder.Reset();
                builder.SetBranding("Ford", "Mustang GT");
                builder.SetEngine("V12");
            }

            public void ConstructSUV()
            {
                builder.Reset();
                builder.SetBranding("Ford", "Endeavour");
                builder.SetEngine("V8");
            }
        }
    }
}
