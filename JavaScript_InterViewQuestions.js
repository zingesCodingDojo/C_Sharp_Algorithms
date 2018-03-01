function isPallindrome(myInput){
  return myInput.split("").reverse().join("");
};

var test = isPallindrome("LevkeL");
console.log(test);

function checkInstance(myChar, myString){
  var myCounter = 0;
  for(var items = 0; items < myString.length; items++){

    if(myChar == myString[items]){
      myCounter++
    }
  }
  //console.log(myStorage)
  return myCounter;
}

var checkVars = checkInstance("S", "Sup, HoSSSSS");
console.log(checkVars);

// Given an array of numbers from 1 - 100
// 10 digit array
// exactly 1 number in the array is a dupe. Write a method to find that dupe!

function checkDupes(arr){
  var results = [];
  for(var i = 0; i < arr.length; i++){
    if(results[arr[i]] === undefined){
      results[arr[i]] = 1;
      console.log(results[arr[i]]);
    }
    else{
      console.log("Number already found before... " + arr[i]);
      return arr[i];
    }
  }
  return false;
};

// var dupper = checkDupes([6, 1, 2, 3, 4, 41, 5, 6, 7, 8, 8]);
// console.log(dupper);

function objDupes(arr){
  var dupeArray = [];
  var results = {};
  for(var i = 0; i < arr.length; i++){
    if(results[arr[i]] === undefined){
      results[arr[i]] = 1;
    }
    else{
      dupeArray.push(arr[i]);
    }
  };
  return dupeArray;
}
var dupper2 = objDupes([6, 1, 2, 3, 4, 41, 5, 6, 7, 8, 8]);
console.log(dupper2);

// 1, 2, 2, 5

