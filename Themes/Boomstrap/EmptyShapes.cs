public class EmptyShapes : IShapeTableProvider {

        public void Discover(ShapeTableBuilder builder) {
            builder.Describe("Parts_ProjectionPart")
                .OnDisplaying(displaying => {
                    var shape = displaying.Shape;
                    if (shape.List.Items.Count == 0) {
                        shape.Metadata.Alternates.Add("Parts_ProjectionPart__Empty");
                    }
                });
        }
    }

