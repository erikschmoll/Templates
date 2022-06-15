import { StyleSheet } from 'react-native';
import Colors from '../../../../application/common/colors';

export default StyleSheet.create({
    button: {
        alignItems: 'center',
        justifyContent: 'center',
        paddingVertical: 12,
        paddingHorizontal: 32,
        elevation: 3,
        borderRadius: 4,
        backgroundColor: Colors.surface,
        borderColor: Colors.primary,
        borderWidth: 2
    },
    text: {
        fontSize: 16,
        lineHeight: 21,
        fontWeight: 'bold',
        letterSpacing: 0.25,
        color: Colors.primary,
    }
});