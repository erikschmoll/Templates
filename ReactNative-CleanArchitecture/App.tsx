import React from 'react';
import { StatusBar, SafeAreaView } from 'react-native';
import { Colors } from 'react-native/Libraries/NewAppScreen';
import LogIn from './src/presentation/components/logIn/index'

const App = () => {
  const backgroundStyle = {
    flex: 1,
    backgroundColor: Colors.lighter,
  };

  return (
    <SafeAreaView style={backgroundStyle}>
      <StatusBar barStyle="dark-content" backgroundColor="white" />
      <LogIn />
    </SafeAreaView>
  );
};

export default App;
