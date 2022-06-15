import React from 'react';
import { View } from 'react-native';
import styles from './styles';

import LogInComponent from '../../components/logIn/logInComponent';
import PreTripTestComponent from '../../components/preTripTest/index';
import AppInfoComponent from '../../../infrastructure/components/app-info/index';

const LogInContainer = () => {
    return (
        <View style={styles.container}>
            <View style={styles.boxLogIn}>
                <LogInComponent />
            </View>
            <View style={styles.boxTest}>
                <PreTripTestComponent />
            </View>
            <View style={styles.boxInfo}>
                <AppInfoComponent />
            </View>
        </View>
    );
}

export default LogInContainer;