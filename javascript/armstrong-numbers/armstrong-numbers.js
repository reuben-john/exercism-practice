//
// This is only a SKELETON file for the 'Armstrong numbers' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

export const validate = num => {
  // single digits always Armstrong numbers
  // double digits never Armstrong numbers
  let answer = false;

  if (num < 10) answer = true;
  else if (num < 100) answer = false;
  else {
    // split number to array
    let splitNum = num.toString().split("");
    let length = splitNum.length;
    let total = 0;

    // multiply each digit by power of number length
    splitNum.forEach(digit => {
      total += Math.pow(digit, length);
    });

    if (total == num) answer = true;
    else answer = false;
  }
  return answer;
};
