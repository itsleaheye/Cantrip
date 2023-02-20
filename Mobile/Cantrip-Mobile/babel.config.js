module.exports = function(api) {
  api.cache(true);
  return {
    presets: ['babel-preset-expo'],
    plugins: [
      [
        '@babel/plugin-transform-runtime',
        {
            absoluteRuntime: false,
            corejs: false,
            helpers: true,
            regenerator: true,
            version: '7.0.0-beta.0',
        },
      ],
      'react-native-reanimated/plugin',
    ],
  }
};
