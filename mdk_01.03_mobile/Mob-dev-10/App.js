import * as React from 'react'
import {
	Alert,
	Image,
	ImageBackground,
	Text,
	TouchableOpacity,
	View,
} from 'react-native'

function App() {
	const image = { uri: 'https://legacy.reactjs.org/logo-og.png' }
	return (
		<View
			style={{
				flex: 1,
			}}
		>
			<ImageBackground
				source={image}
				resizeMode='cover'
				style={{ flex: 1, justifyContent: 'center' }}
			>
				<View
					style={{ flex: 1, justifyContent: 'center', alignItems: 'center' }}
				>
					<Text style={{ color: 'white', fontWeight: 700 }}>Click Tax!</Text>
					<TouchableOpacity onPress={() => Alert.alert('Ты нажал!')}>
						<Image
							style={{ width: 66, height: 66 }}
							source={{
								uri: 'https://cdn-icons-png.flaticon.com/512/518/518713.png',
							}}
						/>
					</TouchableOpacity>
				</View>
			</ImageBackground>
		</View>
	)
}

export default App
