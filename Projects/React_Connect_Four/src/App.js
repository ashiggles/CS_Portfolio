import { useState } from "react";

function Square({backgroundState, onColumnClick}) 
{
    // return square
    return (
        <button 
            className={backgroundState}
            onClick={onColumnClick}
        >
            
        </button>
    );
};

export default function Board() 
{
    // Purple is next state, other state is green
    const [purpleIsNext, setPurpleIsNext] = useState(true);
    // Set square
    const [squares, setSquares] = useState(Array(42).fill("square"));
    // Handle click
    function handleClick(i, iRow, iColumn)
    {
        // Copy array
        const nextSquares = squares.slice();
        // Check if there's a winner
        if (status.includes("Winner"))
        {
            console.log("Already a winner");
        }
        else if (purpleIsNext)
        {
            for (let x = 5; x >= 0; x--)
            {
                if (squares[(x * 7 + iColumn)] == "square")
                {
                    nextSquares[(x * 7 + iColumn)] = "player1";
                    break;
                }
            }
        }
        else
        {
            for (let x = 5; x >= 0; x--)
            {
                if (squares[(x * 7 + iColumn)] == "square")
                {
                    nextSquares[(x * 7 + iColumn)] = "player2";
                    break;
                }
            }
        }
        setSquares(nextSquares);
        setPurpleIsNext(!purpleIsNext);
    }   
    //calculate winner
    const winner = calculateWinner(squares);
    let status;
    let startNew;
    if (winner)
    {
        status = "Winner: " + winner;
        startNew = "Please refresh page to start a new game...";
    }
    else if (squares.indexOf("square") < 0)
    {
        // Game is a tie
        status = "Tie";
    }
    else
    {
        status = "Next player: " + (purpleIsNext ? "Player 1" : "Player 2");
    }
    // Create game board
    return (
        <>
            <h1>React Connect Four</h1>
            <h3>Player 1: Purple, Player 2: Green</h3>
            <div className="board-row">
                <Square backgroundState={squares[0]} onColumnClick={() => handleClick(0, 0, 0)} />
                <Square backgroundState={squares[1]} onColumnClick={() => handleClick(1, 0, 1)} />
                <Square backgroundState={squares[2]} onColumnClick={() => handleClick(2, 0, 2)} />
                <Square backgroundState={squares[3]} onColumnClick={() => handleClick(3, 0, 3)} />
                <Square backgroundState={squares[4]} onColumnClick={() => handleClick(4, 0, 4)} />
                <Square backgroundState={squares[5]} onColumnClick={() => handleClick(5, 0, 5)} />
                <Square backgroundState={squares[6]} onColumnClick={() => handleClick(6, 0, 6)} />
            </div>
            <div className="board-row">
                <Square backgroundState={squares[7]} onColumnClick={() => handleClick(7, 1, 0)} />
                <Square backgroundState={squares[8]} onColumnClick={() => handleClick(8, 1, 1)} />
                <Square backgroundState={squares[9]} onColumnClick={() => handleClick(9, 1, 2)} />
                <Square backgroundState={squares[10]} onColumnClick={() => handleClick(10, 1, 3)} />
                <Square backgroundState={squares[11]} onColumnClick={() => handleClick(11, 1, 4)} />
                <Square backgroundState={squares[12]} onColumnClick={() => handleClick(12, 1, 5)} />
                <Square backgroundState={squares[13]} onColumnClick={() => handleClick(13, 1, 6)} />
            </div>
            <div className="board-row">
                <Square backgroundState={squares[14]} onColumnClick={() => handleClick(14, 2, 0)} />
                <Square backgroundState={squares[15]} onColumnClick={() => handleClick(15, 2, 1)} />
                <Square backgroundState={squares[16]} onColumnClick={() => handleClick(16, 2, 2)} />
                <Square backgroundState={squares[17]} onColumnClick={() => handleClick(17, 2, 3)} />
                <Square backgroundState={squares[18]} onColumnClick={() => handleClick(18, 2, 4)} />
                <Square backgroundState={squares[19]} onColumnClick={() => handleClick(19, 2, 5)} />
                <Square backgroundState={squares[20]} onColumnClick={() => handleClick(20, 2, 6)} />
            </div>
            <div className="board-row">
                <Square backgroundState={squares[21]} onColumnClick={() => handleClick(21, 3, 0)} />
                <Square backgroundState={squares[22]} onColumnClick={() => handleClick(22, 3, 1)} />
                <Square backgroundState={squares[23]} onColumnClick={() => handleClick(23, 3, 2)} />
                <Square backgroundState={squares[24]} onColumnClick={() => handleClick(24, 3, 3)} />
                <Square backgroundState={squares[25]} onColumnClick={() => handleClick(25, 3, 4)} />
                <Square backgroundState={squares[26]} onColumnClick={() => handleClick(26, 3, 5)} />
                <Square backgroundState={squares[27]} onColumnClick={() => handleClick(27, 3, 6)} />
            </div>
            <div className="board-row">
                <Square backgroundState={squares[28]} onColumnClick={() => handleClick(28, 4, 0)} />
                <Square backgroundState={squares[29]} onColumnClick={() => handleClick(29, 4, 1)} />
                <Square backgroundState={squares[30]} onColumnClick={() => handleClick(30, 4, 2)} />
                <Square backgroundState={squares[31]} onColumnClick={() => handleClick(31, 4, 3)} />
                <Square backgroundState={squares[32]} onColumnClick={() => handleClick(32, 4, 4)} />
                <Square backgroundState={squares[33]} onColumnClick={() => handleClick(33, 4, 5)} />
                <Square backgroundState={squares[34]} onColumnClick={() => handleClick(34, 4, 6)} />
            </div>
            <div className="board-row">
                <Square backgroundState={squares[35]} onColumnClick={() => handleClick(35, 5, 0)} />
                <Square backgroundState={squares[36]} onColumnClick={() => handleClick(36, 5, 1)} />
                <Square backgroundState={squares[37]} onColumnClick={() => handleClick(37, 5, 2)} />
                <Square backgroundState={squares[38]} onColumnClick={() => handleClick(38, 5, 3)} />
                <Square backgroundState={squares[39]} onColumnClick={() => handleClick(39, 5, 4)} />
                <Square backgroundState={squares[40]} onColumnClick={() => handleClick(40, 5, 5)} />
                <Square backgroundState={squares[41]} onColumnClick={() => handleClick(41, 5, 6)} />
            </div>
            <div className="status">{status}</div>
            <div className="startNew">{startNew}</div>
        </>
    );
};

function calculateWinner(squares) 
{
    // Winning combinations
    const lines = [
      [0, 1, 2, 3],
      [1, 2, 3, 4],
      [2, 3, 4, 5],
      [3, 4, 5, 6],
      [7, 8, 9, 10],
      [8, 9, 10, 11],
      [9, 10, 11, 12],
      [10, 11, 12, 13],
      [14, 15, 16, 17],
      [15, 16, 17, 18],
      [16, 17, 18, 19],
      [17, 18, 19, 20],
      [21, 22, 23, 24],
      [22, 23, 24, 25],
      [23, 24, 25, 26],
      [22, 25, 26, 27],
      [28, 29, 30, 31],
      [29, 30, 31, 32],
      [30, 31, 32, 33],
      [31, 32, 33, 34],
      [35, 36, 37, 38],
      [36, 37, 38, 39],
      [37, 38, 39, 40],
      [38, 39, 40, 41],
      [0, 7, 14, 21],
      [7, 14, 21, 28],
      [14, 21, 28, 35],
      [1, 8, 15, 22],
      [8, 15, 22, 29],
      [15, 22, 29, 36],
      [2, 9, 16, 23],
      [9, 16, 23, 30],
      [16, 23, 30, 37],
      [3, 10, 17, 24],
      [10, 17, 24, 31],
      [17, 24, 31, 38],
      [4, 11, 18, 25],
      [11, 18, 25, 32],
      [18, 25, 32, 39],
      [5, 12, 19, 26],
      [12, 19, 26, 33],
      [19, 26, 33, 40],
      [6, 13, 20, 27],
      [13, 20, 27, 34],
      [20, 27, 34, 41],
      [14, 22, 30, 38],
      [7, 15, 23, 31],
      [15, 23, 31, 39],
      [0, 8, 16, 24],
      [8, 16, 24, 32],
      [16, 24, 32, 40],
      [1, 9, 17, 25],
      [9, 17, 25, 33],
      [17, 25, 33, 41],
      [2, 10, 18, 26],
      [10, 18, 26, 34],
      [3, 11, 19, 27],
      [3, 9, 15, 21],
      [4, 10, 16, 22],
      [10, 16, 22, 28],
      [5, 11, 17, 23],
      [11, 17, 23, 29],
      [17, 23, 29, 35],
      [6, 12, 18, 24],
      [12, 18, 24, 30],
      [18, 24, 30, 36],
      [13, 19, 25, 31],
      [19, 25, 31, 37],
      [20, 26, 32, 38]
    ];
    for (let i = 0; i < lines.length; i++) {
      const [a, b, c, d] = lines[i];
      if (squares[a] !== "square" && squares[a] && squares[a] === squares[b] && squares[a] === squares[c] && squares[a] === squares[d])
      {
        return squares[a];
      }
    }
    return null;
}