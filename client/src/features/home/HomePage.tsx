import { Box, Typography } from "@mui/material";
import Slider from "react-slick";

export default function HomePage() {
  const settings = {
    dots: true,
    infinite: true,
    speed: 500,
    slidesToShow: 1,
    slidesToScroll: 1,
  };

  return (
    <>
      <Slider {...settings}>
        <div>
          <img
            src="/images/hero1.png"
            alt="hero"
            style={{ display: "block", width: "100%", maxHeight: 500 }}
          />
        </div>
        <div>
          <img
            src="/images/hero2.png"
            alt="hero"
            style={{ display: "block", width: "100%", maxHeight: 500 }}
          />
        </div>
        <div>
          <img
            src="/images/hero3.png"
            alt="hero"
            style={{ display: "block", width: "100%", maxHeight: 500 }}
          />
        </div>
      </Slider>
      <Box
        display="flex"
        justifyContent="center"
        flexDirection="column"
        textAlign="center"
        sx={{ p: 4 }}
      >
        <Typography variant="h2">Welcome to Faux Ventures</Typography>
        <br />
        <Typography variant="h4">
          Get prepped for your next adventure
        </Typography>
      </Box>
    </>
  );
}
