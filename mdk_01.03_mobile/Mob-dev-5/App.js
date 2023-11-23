import { Button, Input } from '@rneui/themed'
import * as React from 'react'
import { StyleSheet, Text, View } from 'react-native'
import Icon from 'react-native-vector-icons/MaterialCommunityIcons'
export default function App() {
	const InputCustom = () => {
		return (
			<Input
				containerStyle={{}}
				disabledInputStyle={{ background: '#ddd' }}
				inputContainerStyle={{}}
				errorStyle={{}}
				errorProps={{}}
				inputStyle={{}}
				label='Введите имя'
				labelStyle={{}}
				labelProps={{}}
				leftIcon={<Icon name='account-outline' size={20} />}
				leftIconContainerStyle={{}}
				rightIconContainerStyle={{}}
				placeholder='name'
			/>
		)
	}
	return (
		<View style={styles.container}>
			<Text style={{ fontSize: 24 }}>
				ИСП Амет и Даша - Построение интерфейса
			</Text>
			<View style={styles.containerHorizontal}>
				<Text style={styles.HorizText}>Горизонтальный вывод элементов</Text>
				<Button
					buttonStyle={{
						borderColor: 'transparent',
						borderWidth: 0,
						borderRadius: 30,
					}}
					color='purple'
					containerStyle={{ margin: 5 }}
					title='Button'
					style={styles.ButtonHoriz}
				/>
				<Button
					buttonStyle={{
						borderColor: 'transparent',
						borderWidth: 0,
						borderRadius: 30,
					}}
					color='purple'
					containerStyle={{ margin: 5 }}
					title='Button'
					style={styles.ButtonHoriz}
				/>
				<Button
					buttonStyle={{
						borderColor: 'transparent',
						borderWidth: 0,
						borderRadius: 30,
					}}
					color='purple'
					containerStyle={{ margin: 5 }}
					title='Button'
					style={styles.ButtonHoriz}
				/>
			</View>
			<View style={{ marginTop: 50 }}>
				<Text>Вертикальный вывод элементов</Text>
				<Button
					buttonStyle={{
						borderColor: 'transparent',
						borderWidth: 0,
						borderRadius: 30,
					}}
					color='purple'
					containerStyle={{ margin: 5 }}
					title='Button'
				/>
				<Button
					buttonStyle={{
						borderColor: 'transparent',
						borderWidth: 0,
						borderRadius: 30,
					}}
					color='purple'
					containerStyle={{ margin: 5 }}
					title='Button'
				/>
			</View>

			<View style={{ marginRight: 150, marginTop: 30 }}>
				<Text>Первая строка</Text>
				<Text>Вторая строка</Text>
				<Button
					buttonStyle={{
						borderColor: 'transparent',
						borderWidth: 0,
						borderRadius: 30,
						width: 200,
					}}
					color='purple'
				>
					SPAN
				</Button>
			</View>
			<View
				style={{
					marginLeft: 100,
					marginRight: 50,
					alignItems: 'center',
					marginTop: 40,
					display: 'flex',
					flexDirection: 'row',
				}}
			>
				<InputCustom />
				<Button
					buttonStyle={{
						borderColor: 'transparent',
						borderWidth: 0,
						borderRadius: 30,
						width: 80,
					}}
					color='purple'
					title='button'
				/>
			</View>
		</View>
	)
}

const styles = StyleSheet.create({
	container: {
		flex: 1,
		backgroundColor: '#fff',
		alignItems: 'center',
		justifyContent: 'center',
	},
	text: {
		fontSize: 14,
		lineHeight: 21,
		fontWeight: 'bold',
		letterSpacing: 0.25,
		color: 'white',
	},
	containerHorizontal: {
		flexDirection: 'row',
		height: 'auto',
	},
	HorizText: {
		flex: 1,
		flexDirection: 'column',
		marginBottom: 10,
	},
})
