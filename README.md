## Project Name: Smart Parking Lot Simulator

### Brief Description
This project simulates an advanced parking management system within a virtual environment. Using advanced AI techniques and procedural content generation, this simulation provides dynamic interactions between autonomous parking bots, a player-controlled car, and obstacles within the parking lot. The goal is to manage the parking space efficiently while avoiding collisions with rogue elements represented as enemy cones.

### How to Run
1. **Installation:**
   - Navigate to the project directory in your terminal.
   - Run `npm install` to install all dependencies.

2. **Starting the Simulation:**
   - In the project directory, run the command `npx vite` to start the development server.
   - Open a web browser and go to `http://localhost:5173` to view the simulation.

### Controls
- **Arrow Keys**: Use the arrow keys to control the movement of the player's car.
- **Objective**: The player must navigate the parking lot, destroying enemy cones (red cones) that threaten the parking bot.

### Implemented Topics
1. **Wandering Algorithm**:
   - The blue parking bot uses a wandering algorithm as its initial state to navigate through the parking lot idly.

2. **A-star Search Algorithm**:
   - Implemented to enable the parking bot to find the most efficient path from a found car to a designated parking spot.

3. **State Machines**:
   - Utilized for both the player and the parking bot to manage different states of behaviors and transitions based on interactions within the game environment.

4. **Procedural Content Generation**:
   - Trees are procedurally generated across the map using an L-System algorithm to enhance the environment and provide variability in gameplay.

5. **Collision Detection**:
   - Handles interactions between the player's car and enemies. Colliding with an enemy cone will destroy it. If an enemy cone reaches the parking bot, it will destroy the bot, ending the gameplay.

### Viewing Each Topic in the Application
- **Wandering**: Observe the blue bot as it moves randomly around the parking lot when not engaged in parking activities.
- **A-star Search**: Watch the bot calculate and follow a path when it approaches a car that needs to be parked.
- **State Machines**: Notice the changes in behavior of the player's car and the bot when interacting with different elements of the game (e.g., switching from wandering to parking to charging).
- **Procedural Content Generation**: Each game session will display uniquely positioned trees around the parking lot, showcasing the generated environmental features.
- **Collision Detection**: Try colliding with the red cones to see them being destroyed, or watch a cone reach the parking bot to see the bot being destroyed.

### Additional Notes
This simulation is designed to demonstrate the learnt AI techniques in a fun and interactive way. Future enhancements will include more sophisticated enemy behaviors, improved graphics, and expanded gameplay mechanics.

---
