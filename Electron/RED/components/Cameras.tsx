import React, { Component } from "react"
import CSS from "csstype"
import { rovecomm } from "../../Core/RoveProtocol/Rovecomm"
// import { Packet } from "../../Core/RoveProtocol/Packet"

const h1Style: CSS.Properties = {
  fontFamily: "arial",
  fontSize: "12px",
}
const container: CSS.Properties = {
  display: "flex",
  flexDirection: "column",
  fontFamily: "arial",
  width: "640px",
  borderTopWidth: "28px",
  borderColor: "#990000",
  borderBottomWidth: "2px",
  borderStyle: "solid",
  padding: "5px",
}
const label: CSS.Properties = {
  marginTop: "-10px",
  position: "relative",
  top: "24px",
  left: "3px",
  fontFamily: "arial",
  fontSize: "16px",
  zIndex: 1,
  color: "white",
}
const row: CSS.Properties = {
  display: "flex",
  flexDirection: "row",
}

interface IProps {
  defaultCamera: number
}

interface IState {
  currentCamera: number
  baseAddress: string[]
}

class Cameras extends Component<IProps, IState> {
  constructor(props: any) {
    super(props)
    this.state = {
      currentCamera: this.props.defaultCamera,
      baseAddress: [
        "http://192.168.1.50:8080",
        "http://192.168.1.51:8080",
        "http://192.168.1.139:8081",
        "http://192.168.1.139:8082",
      ],
    }

    // rovecomm.sendCommand(Packet(dataId, data), reliability)
  }

  ConstructAddress() {
    const index = Math.floor((this.state.currentCamera - 1) / 4)
    const camera = ((this.state.currentCamera - 1) % 4) + 1
    const addr = this.state.baseAddress[index]
    if (this.state.currentCamera === 9) {
      return this.state.baseAddress[2]
    }
    if (this.state.currentCamera === 10) {
      return this.state.baseAddress[3]
    }
    return `${addr}/${camera}/stream`
  }

  render(): JSX.Element {
    return (
      <div>
        <div style={label}>Cameras</div>
        <div style={container}>
          <div style={row}>
            {[1, 2, 3, 4, 5, 6, 7, 8, 9, 10].map(num => {
              return (
                <button
                  type="button"
                  key={num}
                  onClick={() => this.setState({ currentCamera: num })}
                  style={{ flexGrow: 1 }}
                >
                  <h1 style={h1Style}>{num}</h1>
                </button>
              )
            })}
          </div>
          <img
            src={this.ConstructAddress()}
            alt={`Camera ${this.state.currentCamera}`}
            style={{ flexGrow: 1 }}
          />
        </div>
      </div>
    )
  }
}

export default Cameras
