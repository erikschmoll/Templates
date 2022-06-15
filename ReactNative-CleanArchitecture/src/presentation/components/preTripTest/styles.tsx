import { StyleSheet } from 'react-native';
import Colors from '../../../application/common/colors';

export default StyleSheet.create({
    container: {
        flex: 1,
        padding: 5,
        backgroundColor: Colors.background,
        borderTopWidth: 1,
        borderBottomWidth: 1,
        borderBottomColor: Colors.black,
        borderTopColor: Colors.black
    },
    boxing: {
        flex: 1,
        flexDirection: 'row',
        alignItems: 'center',
        justifyContent: 'center'
    },
    box: {
        flex: 1,
        padding: 2
    }
});