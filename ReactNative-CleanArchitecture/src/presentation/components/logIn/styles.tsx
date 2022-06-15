import { StyleSheet } from 'react-native';
import Colors from '../../../application/common/colors';

export default StyleSheet.create({
    container: {
        flex: 1,
        backgroundColor: Colors.surface
    },
    boxTitle: {
        flex: 1,
        padding: 5,
        alignItems: 'flex-start',
        justifyContent: 'center',
        backgroundColor: Colors.background
    },
    boxForm: {
        flex: 9,
        padding: 5
    }
});