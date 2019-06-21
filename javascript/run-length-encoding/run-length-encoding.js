//
// This is only a SKELETON file for the 'Run Length Encoding' exercise. It's been provided as a
// convenience to ge t you started writing code faster.
//

export const encode = rawCode => {
  // check string is not empty or single char
  if (rawCode.length <= 1) return "";
  let compressedCode = [];
  let rawCodes = rawCode.split("");

  let currentChar = rawCodes[0];

  // Count number of repeated letters and tally them.
  let chars = "";

  // Seperate chars into arrays
  for (let i = 0; i <= rawCodes.length; i++) {
    if (rawCodes[i] == currentChar) {
      chars += rawCodes[i];
    } else {
      compressedCode.push(chars);
      currentChar = rawCodes[i];
      chars = currentChar;
    }
  }

  // count and compress each set of chars
  for (let i = 0; i < compressedCode.length; i++) {
    if (compressedCode[i].length <= 1) {
      compressedCode[i] = compressedCode[i][0];
    } else {
      compressedCode[i] = compressedCode[i].length + compressedCode[i][0];
    }
  }
  return compressedCode.join("");
};

export const decode = compressedCode => {
  // check string is not empty or single char
  if (compressedCode.length < 1) return "";
  else if (compressedCode.length == 1) return compressedCode;

  let rawCode = [];
  let reg = /([\d]*?[\s]*?[\D])/g;
  let splitCodes = compressedCode.split(reg);

  for (let i = 0; i < splitCodes.length; i++) {
    let snippet = splitCodes[i];
    if (snippet.length <= 1) rawCode.push(snippet);
    else {
      let joinedChars = "";
      let char = snippet[snippet.length - 1];
      let count = snippet.slice(0, snippet.length - 1);
      for (let x = 0; x < parseInt(count); x++) {
        joinedChars += char;
      }
      rawCode.push(joinedChars);
    }
  }

  // Count number of repeated letters and tally them.

  return rawCode.join("");
};
