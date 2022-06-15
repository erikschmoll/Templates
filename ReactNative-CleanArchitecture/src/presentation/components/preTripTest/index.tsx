import React from 'react';
import { View, Text } from 'react-native';
import ButtonOutline from '../../../infrastructure/components/buttons/button-outline-primary/index';
import styles from './styles';

const PreTripTestComponent = () => {
    return (
        <View style={styles.container}>
            <Text>Pruebas pre viaje</Text>
            <View style={styles.boxing}>
                <View style={styles.box}>
                    <ButtonOutline title='Másico'></ButtonOutline>
                </View>
                <View style={styles.box}>
                    <ButtonOutline title='Válvula'></ButtonOutline>
                </View>
                <View style={styles.box}>
                    <ButtonOutline title='GPS'></ButtonOutline>
                </View>
            </View>
        </View>
    );
}

export default PreTripTestComponent;