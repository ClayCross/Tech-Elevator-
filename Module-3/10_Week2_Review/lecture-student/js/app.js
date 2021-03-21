/**************************************************
 *  Math Practice Notes:

    We need to store this information (variables):

    * Configurable: 
    *       Total Number of questions (10)
    *       Lowest operand value (0)
    *       Highest operand value (9)
    * Current Question
    * Number of correct questions
    * Operand 1 & Operand 2 for current question
    * An array of possible answers, including the correct one.

    We need to handle these events:

    * User clicks on an answer
    * User clicks on Start Over
    * 
    * 
    * We need the following functionality:
    * Add event handlers for selecting the answer, and for the start over.
    * Score the user's answer and increment the score if correct
    * Start the game (zero score,Reset the current question to 1)
    * Create the next question
    * Generate two random operands for the next question
    * Generate four possible answers, shuffled , including the correct answer
    * Display the next question
    * Take the Js Question object and update screen elements with the questions values
    * Grade the user's answer and increment the score if correct
    * Go to the next question if there ar more 
    * or End the game if user has answered all questions
    * End the game 
    * Hide the question and possible answers 
    * 
    * 
*****************************************************/

const NUMBER_OF_QUESTIONS_PER_GAME = 3;
const MIN_OPERAND_VALUE = 0;
const MAX_OPERAND_VALUE =9;



//Temporary code
for (let i = 0; i < 5; i++)
{
    console.log(generateQuestion());
}



/**
 * Create the next question
 * Generate two random operands for the next question
 * Generate four possible answers, shuffled, including the correct answer
 * 
 * 
 * 
 */
function generateQuestion(){
let operand1 = getRandomInteger(MIN_OPERAND_VALUE, MAX_OPERAND_VALUE);
let operand2 = getRandomInteger(MIN_OPERAND_VALUE, MAX_OPERAND_VALUE);

let possibleAnswers = [];

// First put the correct answer in the array
possibleAnswers.push(operand1 * operand2);

// Then generate three more answers randomly 
for (let i = 1; i <= 3; i++){
    while (possibleAnswers[i] === undefined){   
    let randomAnswer = getRandomInteger(MIN_OPERAND_VALUE * MIN_OPERAND_VALUE, MAX_OPERAND_VALUE * MAX_OPERAND_VALUE);
    if ( !possibleAnswers.includes(randomAnswer)){
        possibleAnswers[i] = randomAnswer;
    }
  }

}

return {
    operand1: operand1,
    operand2: operand2,
    possibleAnswers: possibleAnswers
}













/**
 * Utility function to generate a random number from min to max (inclusive)
 * @param {number} min The lowest integer to return
 * @param {number} max The highest integer to return 
 */
function getRandomInteger(min, max) {
    return min + Math.floor(Math.random() * Math.floor(max - min + 1));
}

/**
 * Utility function to shuffle the items in an array
 * @param {object} arr
 */
 function shuffleArray(arr) {
    return arr.sort(function (a, b) { return Math.random() - 0.5 })
  }