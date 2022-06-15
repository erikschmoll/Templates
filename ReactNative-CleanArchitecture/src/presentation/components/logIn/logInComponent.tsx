import React from 'react';
import { View, Text } from 'react-native';
import styles from './styles';

const LogInComponent = () => {
    return (
        <View style={styles.container}>
            <View style={styles.boxTitle}>
                <Text>YPF - GAS</Text>
            </View>
            <View style={styles.boxForm}>
                <Text>Formulario</Text>
            </View>
        </View>
    );
}

export default LogInComponent;