import React, { Component } from "react"
import CSS from "csstype"
import { rovecomm } from "../Core/RoveProtocol/Rovecomm"
import GPS from "./components/GPS"
import Log from "./components/Log"
import Map from "./components/Map"
import Waypoints from "./components/Waypoints"
import NewWindowComponent from "../Core/Window"
import RoverOverviewOfNetwork from "../RON/RON"
import RoverAttachmentManager from "../RAM/RAM"
import Cameras from "../Core/components/Cameras"

const row: CSS.Properties = {
  display: "flex",
  flexDirection: "row",
  justifyContent: "space-between",
}
const column: CSS.Properties = {
  display: "flex",
  flexDirection: "column",
  flexGrow: 1,
  marginRight: "5px",
}

interface IProps {}

interface IState {
  storedWaypoints: any
  currentCoords: { lat: number; lon: number }
  ronOpen: boolean
  ramOpen: boolean
  fourthHeight: number
}

class ControlCenter extends Component<IProps, IState> {
  waypointsInstance: any

  constructor(props: IProps) {
    super(props)
    this.state = {
      storedWaypoints: {},
      currentCoords: { lat: 0, lon: 0 },
      ronOpen: false,
      ramOpen: false,
      fourthHeight: window.innerHeight / 4,
    }
    this.updateWaypoints = this.updateWaypoints.bind(this)
    this.updateCoords = this.updateCoords.bind(this)

    window.addEventListener("resize", () => this.setState({ fourthHeight: window.innerHeight / 4 }))
  }

  updateWaypoints(storedWaypoints: any): void {
    this.setState({
      storedWaypoints,
    })
  }

  updateCoords(lat: any, lon: any): void {
    this.setState({
      currentCoords: { lat, lon },
    })
  }

  render(): JSX.Element {
    return (
      <div style={row}>
        {
          // onClose will be fired when the new window is closed
          // everything inside NewWindowComponent is considered props.children and will be
          // displayed in a new window
          this.state.ronOpen && (
            <NewWindowComponent onClose={() => this.setState({ ronOpen: false })} name="RON">
              <RoverOverviewOfNetwork />
            </NewWindowComponent>
          )
        }
        {
          // onClose will be fired when the new window is closed
          // everything inside NewWindowComponent is considered props.children and will be
          // displayed in a new window
          this.state.ramOpen && (
            <NewWindowComponent onClose={() => this.setState({ ramOpen: false })} name="RAM">
              <RoverAttachmentManager />
            </NewWindowComponent>
          )
        }
        <div style={{ ...column, width: "60%" }}>
          <GPS onCoordsChange={this.updateCoords} />
          <Waypoints
            onWaypointChange={this.updateWaypoints}
            currentCoords={this.state.currentCoords}
            ref={instance => {
              this.waypointsInstance = instance
            }}
          />
          <Log />
          <div style={row}>
            <button type="button" onClick={rovecomm.resubscribe} style={{ width: "100px" }}>
              Resubscribe All
            </button>
            <button type="button" onClick={() => this.setState({ ronOpen: true })}>
              Open Rover Overview of Network
            </button>
            <button type="button" onClick={() => this.setState({ ramOpen: true })}>
              Open Rover Attachment Manager
            </button>
          </div>
        </div>
        <div style={{ ...column, width: "40%" }}>
          <Map
            storedWaypoints={this.state.storedWaypoints}
            currentCoords={this.state.currentCoords}
            store={(name: string, coords: any) => this.waypointsInstance.store(name, coords)}
          />
          <Cameras defaultCamera={1} maxHeight={this.state.fourthHeight} style={{ width: "100%" }} />
          <Cameras defaultCamera={2} maxHeight={this.state.fourthHeight} style={{ width: "100%" }} />
          <Cameras defaultCamera={3} maxHeight={this.state.fourthHeight} style={{ width: "100%" }} />
        </div>
      </div>
    )
  }
}

export default ControlCenter
