/** @type {import('tailwindcss').Config} */
module.exports = {
  content: [
    "./**/*.{razor,html,cshtml}"
  ],
  theme: {
    extend: {
      colors: {
        cream: 'rgb(var(--color-cream) / <alpha-value>)',
        forest: 'rgb(var(--color-forest) / <alpha-value>)',
        coral: 'rgb(var(--color-coral) / <alpha-value>)',
        'coral-dark': 'rgb(var(--color-coral-dark) / <alpha-value>)',
        sand: 'rgb(var(--color-sand) / <alpha-value>)',
      },
      fontFamily: {
        display: ['ui-serif', 'Georgia', 'Cambria', '"Times New Roman"', 'Times', 'serif'],
      }
    },
  },
  plugins: [],
}