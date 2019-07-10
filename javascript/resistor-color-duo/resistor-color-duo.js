//
// This is only a SKELETON file for the 'Resistor Color Duo' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

// export const value = colors => {
//   let code1 = COLORS.indexOf(colors[0]).toString();
//   let code2 = COLORS.indexOf(colors[1]).toString();
//   return parseInt(code1 + code2);
// };

export const value = colors => {
  let codes = colors.map(color => COLORS.indexOf(color));
  return parseInt(codes.join(""));
};

export const COLORS = [
  "black",
  "brown",
  "red",
  "orange",
  "yellow",
  "green",
  "blue",
  "violet",
  "grey",
  "white"
];
