import React from 'react';
import { View, Text } from 'react-native';
import styles from './styles';

const AppInfoComponent = () => {
    return (
        <View style={styles.container}>
            <View style={styles.box}>
                <Text>Versión: 1.0.0</Text>
            </View>
            <View style={styles.box}>
                <Text>Compilado: 06/06/2022</Text>
            </View>
        </View>
    );
}

export default AppInfoComponent;