import { Input } from '@rneui/themed'
import { StyleSheet, Text, View } from 'react-native'
export default function App() {
	return (
		<View
			style={{
				flex: 1,

				backgroundColor: '#fff',
				alignItems: 'center',
				justifyContent: 'center',
			}}
		>
			<Text style={{ color: '#000', fontSize: 24 }}>Калькулятор</Text>
			<Input />
		</View>
	)
}
const styles = StyleSheet.create({
	container: {
		flex: 1,
		marginTop: 100,
		backgroundColor: '#fff',
		alignItems: 'center',
		justifyContent: 'center',
	},
	btn: {
		padding: 10,
	},
	txt: {
		fontSize: 16,
		color: 'blue',
	},
})
