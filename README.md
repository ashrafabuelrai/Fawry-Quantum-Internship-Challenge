⚙️ Engine Types
ClassBehaviorGasolineEngineStandard gas engine, tracks internal speedElectronicEngineElectric engine, tracks internal speedMixedHybridEngineUses Electric below 50 km/h, Gasoline at 50+ km/h. Never runs both simultaneously (cost-optimized)

🚘 Car Operations
MethodBehaviorStart()Starts engine at 0 km/hStop()Stops engine — only allowed when speed is 0Accelerate()Increases speed by 20 km/h (max: 200 km/h)Brake()Decreases speed by 20 km/h (min: 0 km/h)

Every speed change notifies the installed engine via OnSpeedChanged(int carSpeed).


🏭 Factory Usage
csharpvar factory = new CarFactory();

// Create a car by engine type
Car gasCar     = factory.CreateCar(EngineType.Gasoline);
Car electricCar = factory.CreateCar(EngineType.Electronic);
Car hybridCar  = factory.CreateCar(EngineType.Hybrid);

// Replace engine on an existing car
factory.ReplaceEngine(gasCar, EngineType.Hybrid);

🔀 Hybrid Engine Logic
Speed < 50 km/h  →  Electronic engine active
Speed >= 50 km/h →  Gasoline engine active
