var px, py; //Position
var goalCounter; //Crates on right place

function drawGameBoard() {
    //Hello player
    var h1 = document.createElement('h1');
    h1.innerHTML = "sokoban the game";
    document.getElementById('startDiv').appendChild(h1);
    var parag = document.createElement('p');
    parag.innerHTML = "Push space to restart the game";
    document.getElementById('startDiv').appendChild(parag);

    // Building playground
    var sokoGameDiv = document.getElementById('sokoMainDiv');
    for (let x = 1; x < 17; x++) { for (let y = 1; y < 20; y++) {
    let element = document.createElement('div');
    element.classList.add('gameGrid');
    document.getElementById('sokoMainDiv').appendChild(element);
    
    // Fill playground whith elements
    if (tileMap01.mapGrid[x - 1][y - 1][0] === "P") {element.classList.add('entity-player-down', 'entity-player-up', 'entity-player-left', 'entity-player-right'); px = x; py = y;}
        else if (tileMap01.mapGrid[x - 1][y - 1][0] === "W") {element.classList.add('wall');}
        else if (tileMap01.mapGrid[x - 1][y - 1][0] === "G") {element.classList.add('goal');}
        else if (tileMap01.mapGrid[x - 1][y - 1][0] === "C") {element.classList.add('crate');}
        else if (tileMap01.mapGrid[x - 1][y - 1][0] === "F") {element.classList.add('fixedcrate');}
        else {element.classList.add('ground');}
        element.id = "x" + x + "y" + y;
        console.log(element.id);
        sokoGameDiv.appendChild(element);
  }}
    console.log(px);
    console.log(py);
}
// Cordinates for the player
function playerMove(direction, oldLocation, x, y) {
    var newLocation = document.getElementById("x" + x + "y" + y);
    var newCrateLocation;
    
    //Moving around the board
    if (direction !== undefined && direction !== null) {
        if (true) {
            if (direction === 37) newCrateLocation = document.getElementById("x" + x + "y" + (y - 1));
            else if (direction === 39) newCrateLocation = document.getElementById("x" + x + "y" + (y + 1));
            else if (direction === 38) newCrateLocation = document.getElementById("x" + (x - 1) + "y" + y);
            else if (direction === 40) newCrateLocation = document.getElementById("x" + (x + 1) + "y" + y);}
    }

    if (newLocation.id !== undefined && newLocation.id !== null && !newLocation.classList.contains('wall') && !newLocation.classList.contains('fixedcrate') && !((newCrateLocation.classList.contains('wall') || newCrateLocation.classList.contains('crate')) && newLocation.classList.contains('crate'))) {
        
        //Moving crates
        if (newLocation.classList.contains('crate') && !newCrateLocation.classList.contains('wall')) {
            console.log(newCrateLocation.id);
            newCrateLocation.classList.add('crate');
            oldLocation.classList.remove('crate');
            oldLocation.classList.add('ground');
            newLocation.classList.remove('crate');

        // Counting crates on the right place
        if (newCrateLocation.classList.contains('goal')){
            newCrateLocation.classList.add('fixedcrate');
            newCrateLocation.classList.add('wall');

            goalCounter = goalCounter + 1 || 1; console.log(goalCounter);
            
            var paraWin = document.createElement("p");
            var element = document.getElementById("messagesDiv");
            element.appendChild(paraWin);
            var texten = 6 - goalCounter + " more to win!";
            element.innerHTML = texten;
            element.className = "score";
            
            // Game done...
            if(goalCounter == 6){
                newLocation.classList.add('entity-player-up')
                var texten = "Congratulations<br />you won!!!";
                element.innerHTML = texten;
                element.className = "winner";
                endGame();
            }
        }}
        
        //Moving player around and changing tile for each direction
        oldLocation.classList.remove('entity-player-down', 'entity-player-up', 'entity-player-left', 'entity-player-right');
        if(direction === 37){ newLocation.classList.add('entity-player-left'); oldLocation = newLocation;}
        else if(direction === 39){ newLocation.classList.add('entity-player-right'); oldLocation = newLocation;}
        else if(direction === 38){ newLocation.classList.add('entity-player-up'); oldLocation = newLocation;}
        else if(direction === 40){ newLocation.classList.add('entity-player-down'); oldLocation = newLocation;}
        px = x;
        py = y;
    }
}

// Ask if restart game
function restartGame() {
    var newGame = window.confirm("Restart game?");
    if (newGame) {
       location.reload();
    }    
}

// Endgame
function endGame() {
let btnNewGame = document.createElement("button");
btnNewGame.innerHTML = "Push to play again";
btnNewGame.onclick = function () {location.reload();};
document.body.appendChild(btnNewGame);
}

// Player movement, Listening to keydown event, cutting of scroll function

window.addEventListener("keydown", function(event) {
    if([32, 37, 38, 39, 40].indexOf(event.keyCode) > - 1) {
        event.preventDefault();
    }
    var playermovecase = event.keyCode;
    var oldLocation = document.getElementById("x" + px + "y" + py);
    switch (playermovecase) {
        case 37:
            playerMove(37, oldLocation, px, py - 1);
            break;
            
        case 39:
            playerMove(39, oldLocation, px, py + 1);
            break;

        case 38:
            playerMove(38, oldLocation, px - 1, py);
            break;

            case 40:
            playerMove(40, oldLocation, px + 1, py);
            break;

        case 32:
            restartGame();
            break;
    }
    console.log(playermovecase);

}, false);


drawGameBoard();


