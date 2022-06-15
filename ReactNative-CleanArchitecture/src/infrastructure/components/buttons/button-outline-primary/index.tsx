import React from 'react';
import { Pressable, Text } from 'react-native';
import { IButtonProps } from '../../../../application/interfaces/button.interface';
import styles from './styles';

class ButtonOutlinePrimaryComponent extends React.Component<IButtonProps, {}> {
    render() {
        const { onPress = () => { }, title = '' } = this.props;
        return (
            <Pressable style={styles.button} onPress={onPress}>
                <Text style={styles.text}>{title}</Text>
            </Pressable>
        );
    }
}


export default ButtonOutlinePrimaryComponent;