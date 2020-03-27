
using System;
using LivingThing.TCCS.Attributes;
using LivingThing.TCCS.Definitions.Javascript;
using LivingThing.TCCS.Definitions.Util;
using Date = System.DateTime;

namespace LivingThing.TCCS.Definitions
{ 
	public class THREE
	{
		public virtual string REVISION { get; set; }
		public enum MOUSE
		{
			LEFT,
			MIDDLE,
			RIGHT
		}
		public enum CullFace
		{
		}
		public virtual CullFace CullFaceNone { get; set; }
		public virtual CullFace CullFaceBack { get; set; }
		public virtual CullFace CullFaceFront { get; set; }
		public virtual CullFace CullFaceFrontBack { get; set; }
		public enum FrontFaceDirection
		{
		}
		public virtual FrontFaceDirection FrontFaceDirectionCW { get; set; }
		public virtual FrontFaceDirection FrontFaceDirectionCCW { get; set; }
		public enum ShadowMapType
		{
		}
		public virtual ShadowMapType BasicShadowMap { get; set; }
		public virtual ShadowMapType PCFShadowMap { get; set; }
		public virtual ShadowMapType PCFSoftShadowMap { get; set; }
		public enum Side
		{
		}
		public virtual Side FrontSide { get; set; }
		public virtual Side BackSide { get; set; }
		public virtual Side DoubleSide { get; set; }
		public enum Shading
		{
		}
		public virtual Shading FlatShading { get; set; }
		public virtual Shading SmoothShading { get; set; }
		public enum Colors
		{
		}
		public virtual Colors NoColors { get; set; }
		public virtual Colors FaceColors { get; set; }
		public virtual Colors VertexColors { get; set; }
		public enum Blending
		{
		}
		public virtual Blending NoBlending { get; set; }
		public virtual Blending NormalBlending { get; set; }
		public virtual Blending AdditiveBlending { get; set; }
		public virtual Blending SubtractiveBlending { get; set; }
		public virtual Blending MultiplyBlending { get; set; }
		public virtual Blending CustomBlending { get; set; }
		public enum BlendingEquation
		{
		}
		public virtual BlendingEquation AddEquation { get; set; }
		public virtual BlendingEquation SubtractEquation { get; set; }
		public virtual BlendingEquation ReverseSubtractEquation { get; set; }
		public virtual BlendingEquation MinEquation { get; set; }
		public virtual BlendingEquation MaxEquation { get; set; }
		public enum BlendingDstFactor
		{
		}
		public virtual BlendingDstFactor ZeroFactor { get; set; }
		public virtual BlendingDstFactor OneFactor { get; set; }
		public virtual BlendingDstFactor SrcColorFactor { get; set; }
		public virtual BlendingDstFactor OneMinusSrcColorFactor { get; set; }
		public virtual BlendingDstFactor SrcAlphaFactor { get; set; }
		public virtual BlendingDstFactor OneMinusSrcAlphaFactor { get; set; }
		public virtual BlendingDstFactor DstAlphaFactor { get; set; }
		public virtual BlendingDstFactor OneMinusDstAlphaFactor { get; set; }
		public virtual BlendingDstFactor DstColorFactor { get; set; }
		public virtual BlendingDstFactor OneMinusDstColorFactor { get; set; }
		public enum BlendingSrcFactor
		{
		}
		public virtual BlendingSrcFactor SrcAlphaSaturateFactor { get; set; }
		public enum DepthModes
		{
		}
		public virtual DepthModes NeverDepth { get; set; }
		public virtual DepthModes AlwaysDepth { get; set; }
		public virtual DepthModes LessDepth { get; set; }
		public virtual DepthModes LessEqualDepth { get; set; }
		public virtual DepthModes EqualDepth { get; set; }
		public virtual DepthModes GreaterEqualDepth { get; set; }
		public virtual DepthModes GreaterDepth { get; set; }
		public virtual DepthModes NotEqualDepth { get; set; }
		public enum Combine
		{
		}
		public virtual Combine MultiplyOperation { get; set; }
		public virtual Combine MixOperation { get; set; }
		public virtual Combine AddOperation { get; set; }
		public enum ToneMapping
		{
		}
		public virtual ToneMapping NoToneMapping { get; set; }
		public virtual ToneMapping LinearToneMapping { get; set; }
		public virtual ToneMapping ReinhardToneMapping { get; set; }
		public virtual ToneMapping Uncharted2ToneMapping { get; set; }
		public virtual ToneMapping CineonToneMapping { get; set; }
		public enum Mapping
		{
		}
		public virtual Mapping UVMapping { get; set; }
		public virtual Mapping CubeReflectionMapping { get; set; }
		public virtual Mapping CubeRefractionMapping { get; set; }
		public virtual Mapping EquirectangularReflectionMapping { get; set; }
		public virtual Mapping EquirectangularRefractionMapping { get; set; }
		public virtual Mapping SphericalReflectionMapping { get; set; }
		public virtual Mapping CubeUVReflectionMapping { get; set; }
		public virtual Mapping CubeUVRefractionMapping { get; set; }
		public enum Wrapping
		{
		}
		public virtual Wrapping RepeatWrapping { get; set; }
		public virtual Wrapping ClampToEdgeWrapping { get; set; }
		public virtual Wrapping MirroredRepeatWrapping { get; set; }
		public enum TextureFilter
		{
		}
		public virtual TextureFilter NearestFilter { get; set; }
		public virtual TextureFilter NearestMipMapNearestFilter { get; set; }
		public virtual TextureFilter NearestMipMapLinearFilter { get; set; }
		public virtual TextureFilter LinearFilter { get; set; }
		public virtual TextureFilter LinearMipMapNearestFilter { get; set; }
		public virtual TextureFilter LinearMipMapLinearFilter { get; set; }
		public enum TextureDataType
		{
		}
		public virtual TextureDataType UnsignedByteType { get; set; }
		public virtual TextureDataType ByteType { get; set; }
		public virtual TextureDataType ShortType { get; set; }
		public virtual TextureDataType UnsignedShortType { get; set; }
		public virtual TextureDataType IntType { get; set; }
		public virtual TextureDataType UnsignedIntType { get; set; }
		public virtual TextureDataType FloatType { get; set; }
		public virtual TextureDataType HalfFloatType { get; set; }
		public enum PixelType
		{
		}
		public virtual PixelType UnsignedShort4444Type { get; set; }
		public virtual PixelType UnsignedShort5551Type { get; set; }
		public virtual PixelType UnsignedShort565Type { get; set; }
		public virtual PixelType UnsignedInt248Type { get; set; }
		public enum PixelFormat
		{
		}
		public virtual PixelFormat AlphaFormat { get; set; }
		public virtual PixelFormat RGBFormat { get; set; }
		public virtual PixelFormat RGBAFormat { get; set; }
		public virtual PixelFormat LuminanceFormat { get; set; }
		public virtual PixelFormat LuminanceAlphaFormat { get; set; }
		public virtual PixelFormat RGBEFormat { get; set; }
		public virtual PixelFormat DepthFormat { get; set; }
		public virtual PixelFormat DepthStencilFormat { get; set; }
		public enum CompressedPixelFormat
		{
		}
		public virtual CompressedPixelFormat RGB_S3TC_DXT1_Format { get; set; }
		public virtual CompressedPixelFormat RGBA_S3TC_DXT1_Format { get; set; }
		public virtual CompressedPixelFormat RGBA_S3TC_DXT3_Format { get; set; }
		public virtual CompressedPixelFormat RGBA_S3TC_DXT5_Format { get; set; }
		public virtual CompressedPixelFormat RGB_PVRTC_4BPPV1_Format { get; set; }
		public virtual CompressedPixelFormat RGB_PVRTC_2BPPV1_Format { get; set; }
		public virtual CompressedPixelFormat RGBA_PVRTC_4BPPV1_Format { get; set; }
		public virtual CompressedPixelFormat RGBA_PVRTC_2BPPV1_Format { get; set; }
		public virtual CompressedPixelFormat RGB_ETC1_Format { get; set; }
		public enum AnimationActionLoopStyles
		{
		}
		public virtual AnimationActionLoopStyles LoopOnce { get; set; }
		public virtual AnimationActionLoopStyles LoopRepeat { get; set; }
		public virtual AnimationActionLoopStyles LoopPingPong { get; set; }
		public enum InterpolationModes
		{
		}
		public virtual InterpolationModes InterpolateDiscrete { get; set; }
		public virtual InterpolationModes InterpolateLinear { get; set; }
		public virtual InterpolationModes InterpolateSmooth { get; set; }
		public enum InterpolationEndingModes
		{
		}
		public virtual InterpolationEndingModes ZeroCurvatureEnding { get; set; }
		public virtual InterpolationEndingModes ZeroSlopeEnding { get; set; }
		public virtual InterpolationEndingModes WrapAroundEnding { get; set; }
		public enum TrianglesDrawModes
		{
		}
		public virtual TrianglesDrawModes TrianglesDrawMode { get; set; }
		public virtual TrianglesDrawModes TriangleStripDrawMode { get; set; }
		public virtual TrianglesDrawModes TriangleFanDrawMode { get; set; }
		public enum TextureEncoding
		{
		}
		public virtual TextureEncoding LinearEncoding { get; set; }
		public virtual TextureEncoding sRGBEncoding { get; set; }
		public virtual TextureEncoding GammaEncoding { get; set; }
		public virtual TextureEncoding RGBEEncoding { get; set; }
		public virtual TextureEncoding LogLuvEncoding { get; set; }
		public virtual TextureEncoding RGBM7Encoding { get; set; }
		public virtual TextureEncoding RGBM16Encoding { get; set; }
		public virtual TextureEncoding RGBDEncoding { get; set; }
		public enum DepthPackingStrategies
		{
		}
		public virtual DepthPackingStrategies BasicDepthPacking { get; set; }
		public virtual DepthPackingStrategies RGBADepthPacking { get; set; }
		public virtual void warn(object message, object[] optionalParams) { }
		public virtual void error(object message, object[] optionalParams) { }
		public virtual void log(object message, object[] optionalParams) { }
		public class TypedArray : TypeAlias
		{
			public TypedArray(Union<Int8Array, Uint8Array, Uint8ClampedArray, Int16Array, Uint16Array, Int32Array, Uint32Array, Float32Array, Float64Array> value) { Value = value; }
			public static implicit operator TypedArray(Union<Int8Array, Uint8Array, Uint8ClampedArray, Int16Array, Uint16Array, Int32Array, Uint32Array, Float32Array, Float64Array> value) { return new TypedArray(value); }
		}
		public partial class AnimationAction
		{
			public virtual AnimationActionLoopStyles loop { get; set; }
			public virtual double time { get; set; }
			public virtual double timeScale { get; set; }
			public virtual double weight { get; set; }
			public virtual double repetitions { get; set; }
			public virtual bool paused { get; set; }
			public virtual bool enabled { get; set; }
			public virtual bool clampWhenFinished { get; set; }
			public virtual bool zeroSlopeAtStart { get; set; }
			public virtual bool zeroSlopeAtEnd { get; set; }
			public virtual AnimationAction play() => default(AnimationAction);
			public virtual AnimationAction stop() => default(AnimationAction);
			public virtual AnimationAction reset() => default(AnimationAction);
			public virtual bool isRunning() => default(bool);
			public virtual bool isScheduled() => default(bool);
			public virtual AnimationAction startAt(double time) => default(AnimationAction);
			public virtual AnimationAction setLoop(AnimationActionLoopStyles mode, double repetitions) => default(AnimationAction);
			public virtual AnimationAction setEffectiveWeight(double weight) => default(AnimationAction);
			public virtual double getEffectiveWeight() => default(double);
			public virtual AnimationAction fadeIn(double duration) => default(AnimationAction);
			public virtual AnimationAction fadeOut(double duration) => default(AnimationAction);
			public virtual AnimationAction crossFadeFrom(AnimationAction fadeOutAction, double duration, bool warp) => default(AnimationAction);
			public virtual AnimationAction crossFadeTo(AnimationAction fadeInAction, double duration, bool warp) => default(AnimationAction);
			public virtual AnimationAction stopFading() => default(AnimationAction);
			public virtual AnimationAction setEffectiveTimeScale(double timeScale) => default(AnimationAction);
			public virtual double getEffectiveTimeScale() => default(double);
			public virtual AnimationAction setDuration(double duration) => default(AnimationAction);
			public virtual AnimationAction syncWith(AnimationAction action) => default(AnimationAction);
			public virtual AnimationAction halt(double duration) => default(AnimationAction);
			public virtual AnimationAction warp(double statTimeScale, double endTimeScale, double duration) => default(AnimationAction);
			public virtual AnimationAction stopWarping() => default(AnimationAction);
			public virtual AnimationMixer getMixer() => default(AnimationMixer);
			public virtual AnimationClip getClip() => default(AnimationClip);
			public virtual object getRoot() => default(object);
			public AnimationAction() { }
		}
		public partial class AnimationClip
		{
			public virtual string name { get; set; }
			public virtual KeyframeTrack[] tracks { get; set; }
			public virtual double duration { get; set; }
			public virtual string uuid { get; set; }
			public virtual object[] results { get; set; }
			public AnimationClip(string name, double duration, KeyframeTrack[] tracks) { }
			public virtual void resetDuration() { }
			public virtual AnimationClip trim() => default(AnimationClip);
			public virtual AnimationClip optimize() => default(AnimationClip);
			public virtual AnimationClip CreateFromMorphTargetSequence(string name, MorphTarget[] morphTargetSequence, double fps, bool noLoop) => default(AnimationClip);
			public virtual AnimationClip findByName(AnimationClip[] clipArray, string name) => default(AnimationClip);
			public virtual AnimationClip[] CreateClipsFromMorphTargetSequences(MorphTarget[] morphTargets, double fps, bool noLoop) => default(AnimationClip[]);
			public virtual AnimationClip parse(object json) => default(AnimationClip);
			public virtual AnimationClip parseAnimation(object animation, Bone[] bones, string nodeName) => default(AnimationClip);
			public virtual object toJSON() => default(object);
			public AnimationClip() { }
		}
		public partial class AnimationMixer : EventDispatcher
		{
			public virtual double time { get; set; }
			public virtual double timeScale { get; set; }
			public AnimationMixer(object root) { }
			public virtual AnimationAction clipAction(AnimationClip clip, object root) => default(AnimationAction);
			public virtual AnimationAction existingAction(AnimationClip clip, object root) => default(AnimationAction);
			public virtual AnimationMixer stopAllAction() => default(AnimationMixer);
			public virtual AnimationMixer update(double deltaTime) => default(AnimationMixer);
			public virtual object getRoot() => default(object);
			public virtual void uncacheClip(AnimationClip clip) { }
			public virtual void uncacheRoot(object root) { }
			public virtual void uncacheAction(AnimationClip clip, object root) { }
			public AnimationMixer() { }
		}
		public partial class AnimationObjectGroup
		{
			public partial interface AnimationObjectGroup_Type_0
			{
				double bindingsPerObject { get; set; }
				AnimationObjectGroup_Type_0_Type_0 objects { get; set; }
			}
			public partial interface AnimationObjectGroup_Type_0_Type_0
			{
				double total { get; set; }
				double inUse { get; set; }
			}
			public virtual string uuid { get; set; }
			public virtual AnimationObjectGroup_Type_0 stats { get; set; }
			public AnimationObjectGroup(object[] args) { }
			public virtual void add(object[] args) { }
			public virtual void remove(object[] args) { }
			public virtual void uncache(object[] args) { }
			public AnimationObjectGroup() { }
		}
		public partial class AnimationUtils
		{
			public virtual object arraySlice(object array, double from, double to) => default(object);
			public virtual object convertArray(object array, object type, bool forceClone) => default(object);
			public virtual bool isTypedArray(object @object) => default(bool);
			public virtual double[] getKeyFrameOrder(double times) => default(double[]);
			public virtual object[] sortedArray(object[] values, double stride, double[] order) => default(object[]);
			public virtual void flattenJSON(string[] jsonKeys, object[] times, object[] values, string valuePropertyName) { }
			public AnimationUtils() { }
		}
		public partial class KeyframeTrack
		{
			public virtual string name { get; set; }
			public virtual object[] times { get; set; }
			public virtual object[] values { get; set; }
			public virtual string ValueTypeName { get; set; }
			public virtual Float32Array TimeBufferType { get; set; }
			public virtual Float32Array ValueBufferType { get; set; }
			public virtual InterpolationModes DefaultInterpolation { get; set; }
			public KeyframeTrack(string name, object[] times, object[] values, InterpolationModes interpolation) { }
			public virtual DiscreteInterpolant InterpolantFactoryMethodDiscrete(object result) => default(DiscreteInterpolant);
			public virtual LinearInterpolant InterpolantFactoryMethodLinear(object result) => default(LinearInterpolant);
			public virtual CubicInterpolant InterpolantFactoryMethodSmooth(object result) => default(CubicInterpolant);
			public virtual void setInterpolation(InterpolationModes interpolation) { }
			public virtual InterpolationModes getInterpolation() => default(InterpolationModes);
			public virtual double getValuesize() => default(double);
			public virtual KeyframeTrack shift(double timeOffset) => default(KeyframeTrack);
			public virtual KeyframeTrack scale(double timeScale) => default(KeyframeTrack);
			public virtual KeyframeTrack trim(double startTime, double endTime) => default(KeyframeTrack);
			public virtual bool validate() => default(bool);
			public virtual KeyframeTrack optimize() => default(KeyframeTrack);
			public virtual KeyframeTrack parse(object json) => default(KeyframeTrack);
			public virtual object toJSON(KeyframeTrack track) => default(object);
			public KeyframeTrack() { }
		}
		public partial class PropertyBinding
		{
			public partial interface PropertyBinding_Type_0
			{
				double this[string bindingType] { get; set; }
			}
			public partial interface PropertyBinding_Type_1
			{
				double this[string versioning] { get; set; }
			}
			public partial class Composite
			{
				public Composite(object targetGroup, object path, object parsedPath) { }
				public virtual object getValue(object array, double offset) => default(object);
				public virtual void setValue(object array, double offset) { }
				public virtual void bind() { }
				public virtual void unbind() { }
				public Composite() { }
			}
			public virtual string path { get; set; }
			public virtual object parsedPath { get; set; }
			public virtual object node { get; set; }
			public virtual object rootNode { get; set; }
			public virtual PropertyBinding_Type_0 BindingType { get; set; }
			public virtual PropertyBinding_Type_1 Versioning { get; set; }
			public virtual Function[] GetterByBindingType { get; set; }
			public virtual Function[][] SetterByBindingTypeAndVersioning { get; set; }
			public PropertyBinding(object rootNode, string path, object parsedPath) { }
			public virtual object getValue(object targetArray, double offset) => default(object);
			public virtual void setValue(object sourceArray, double offset) { }
			public virtual void bind() { }
			public virtual void unbind() { }
			public virtual Union<PropertyBinding, PropertyBinding.Composite> create(object root, object path, object parsedPath) => default(Union<PropertyBinding, PropertyBinding.Composite>);
			public virtual object parseTrackName(string trackName) => default(object);
			public virtual object findNode(object root, string nodeName) => default(object);
			public PropertyBinding() { }
		}
		public partial class PropertyMixer
		{
			public virtual object binding { get; set; }
			public virtual double valueSize { get; set; }
			public virtual object buffer { get; set; }
			public virtual double cumulativeWeight { get; set; }
			public virtual double useCount { get; set; }
			public virtual double referenceCount { get; set; }
			public PropertyMixer(object binding, string typeName, double valueSize) { }
			public virtual void accumulate(double accuIndex, double weight) { }
			public virtual void apply(double accuIndex) { }
			public virtual void saveOriginalState() { }
			public virtual void restoreOriginalState() { }
			public PropertyMixer() { }
		}
		public partial class BooleanKeyframeTrack : KeyframeTrack
		{
			public BooleanKeyframeTrack(string name, object[] times, object[] values) { }
			public BooleanKeyframeTrack() { }
		}
		public partial class ColorKeyframeTrack : KeyframeTrack
		{
			public ColorKeyframeTrack(string name, object[] times, object[] values, InterpolationModes interpolation) { }
			public ColorKeyframeTrack() { }
		}
		public partial class NumberKeyframeTrack : KeyframeTrack
		{
			public NumberKeyframeTrack(string name, object[] times, object[] values, InterpolationModes interpolation) { }
			public NumberKeyframeTrack() { }
		}
		public partial class QuaternionKeyframeTrack : KeyframeTrack
		{
			public QuaternionKeyframeTrack(string name, object[] times, object[] values, InterpolationModes interpolation) { }
			public QuaternionKeyframeTrack() { }
		}
		public partial class StringKeyframeTrack : KeyframeTrack
		{
			public StringKeyframeTrack(string name, object[] times, object[] values, InterpolationModes interpolation) { }
			public StringKeyframeTrack() { }
		}
		public partial class VectorKeyframeTrack : KeyframeTrack
		{
			public VectorKeyframeTrack(string name, object[] times, object[] values, InterpolationModes interpolation) { }
			public VectorKeyframeTrack() { }
		}
		public partial class Camera : Object3D
		{
			public virtual Matrix4 matrixWorldInverse { get; set; }
			public virtual Matrix4 projectionMatrix { get; set; }
			public virtual bool isCamera { get; set; }
			public Camera() { }
			public virtual Camera copy(Camera source, bool recursive) => default(Camera);
			public virtual Vector3 getWorldDirection(Vector3 target) => default(Vector3);
			public virtual void updateMatrixWorld(bool force) { }
		}
		public partial class CubeCamera : Object3D
		{
			public class CubeCamera_Type_0 : Enumerated
			{
				public static string CubeCamera = "CubeCamera";
				public static implicit operator CubeCamera_Type_0(string value) { return new CubeCamera_Type_0(value); }
				public CubeCamera_Type_0(object value) { Value = value; }
			}
			public virtual CubeCamera_Type_0 type { get; set; }
			public virtual WebGLRenderTargetCube renderTarget { get; set; }
			public CubeCamera(double near, double far, double cubeResolution) { }
			public virtual void updateCubeMap(Renderer renderer, Scene scene) { }
			public virtual void update(WebGLRenderer renderer, Scene scene) { }
			public CubeCamera() { }
		}
		public partial class OrthographicCamera : Camera
		{
			public class OrthographicCamera_Type_0 : Enumerated
			{
				public static string OrthographicCamera = "OrthographicCamera";
				public static implicit operator OrthographicCamera_Type_0(string value) { return new OrthographicCamera_Type_0(value); }
				public OrthographicCamera_Type_0(object value) { Value = value; }
			}
			public partial interface OrthographicCamera_Type_1
			{
				bool enabled { get; set; }
				double fullWidth { get; set; }
				double fullHeight { get; set; }
				double offsetX { get; set; }
				double offsetY { get; set; }
				double width { get; set; }
				double height { get; set; }
			}
			public virtual OrthographicCamera_Type_0 type { get; set; }
			public virtual bool isOrthographicCamera { get; set; }
			public virtual double zoom { get; set; }
			public virtual Union<object, OrthographicCamera_Type_1> view { get; set; }
			public virtual double left { get; set; }
			public virtual double right { get; set; }
			public virtual double top { get; set; }
			public virtual double bottom { get; set; }
			public virtual double near { get; set; }
			public virtual double far { get; set; }
			public OrthographicCamera(double left, double right, double top, double bottom, double near, double far) { }
			public virtual void updateProjectionMatrix() { }
			public virtual void setViewOffset(double fullWidth, double fullHeight, double offsetX, double offsetY, double width, double height) { }
			public virtual void clearViewOffset() { }
			public virtual object toJSON(object meta) => default(object);
			public OrthographicCamera() { }
		}
		public partial class PerspectiveCamera : Camera
		{
			public class PerspectiveCamera_Type_0 : Enumerated
			{
				public static string PerspectiveCamera = "PerspectiveCamera";
				public static implicit operator PerspectiveCamera_Type_0(string value) { return new PerspectiveCamera_Type_0(value); }
				public PerspectiveCamera_Type_0(object value) { Value = value; }
			}
			public partial interface PerspectiveCamera_Type_1
			{
				bool enabled { get; set; }
				double fullWidth { get; set; }
				double fullHeight { get; set; }
				double offsetX { get; set; }
				double offsetY { get; set; }
				double width { get; set; }
				double height { get; set; }
			}
			public virtual PerspectiveCamera_Type_0 type { get; set; }
			public virtual bool isPerspectiveCamera { get; set; }
			public virtual double zoom { get; set; }
			public virtual double fov { get; set; }
			public virtual double aspect { get; set; }
			public virtual double near { get; set; }
			public virtual double far { get; set; }
			public virtual double focus { get; set; }
			public virtual Union<object, PerspectiveCamera_Type_1> view { get; set; }
			public virtual double filmGauge { get; set; }
			public virtual double filmOffset { get; set; }
			public PerspectiveCamera(double fov, double aspect, double near, double far) { }
			public virtual void setFocalLength(double focalLength) { }
			public virtual double getFocalLength() => default(double);
			public virtual double getEffectiveFOV() => default(double);
			public virtual double getFilmWidth() => default(double);
			public virtual double getFilmHeight() => default(double);
			public virtual void setViewOffset(double fullWidth, double fullHeight, double x, double y, double width, double height) { }
			public virtual void clearViewOffset() { }
			public virtual void updateProjectionMatrix() { }
			public virtual object toJSON(object meta) => default(object);
			public virtual void setLens(double focalLength, double frameHeight) { }
			public PerspectiveCamera() { }
		}
		public partial class StereoCamera : Camera
		{
			public class StereoCamera_Type_0 : Enumerated
			{
				public static string StereoCamera = "StereoCamera";
				public static implicit operator StereoCamera_Type_0(string value) { return new StereoCamera_Type_0(value); }
				public StereoCamera_Type_0(object value) { Value = value; }
			}
			public virtual StereoCamera_Type_0 type { get; set; }
			public virtual double aspect { get; set; }
			public virtual double eyeSep { get; set; }
			public virtual PerspectiveCamera cameraL { get; set; }
			public virtual PerspectiveCamera cameraR { get; set; }
			public StereoCamera() { }
			public virtual void update(PerspectiveCamera camera) { }
		}
		public partial class ArrayCamera : PerspectiveCamera
		{
			public virtual PerspectiveCamera[] cameras { get; set; }
			public virtual bool isArrayCamera { get; set; }
			public ArrayCamera(PerspectiveCamera[] cameras) { }
			public ArrayCamera() { }
		}
		public partial class BufferAttribute
		{
			public partial interface BufferAttribute_Type_0
			{
				double offset { get; set; }
				double count { get; set; }
			}
			public partial interface BufferAttribute_Type_1
			{
				double r { get; set; }
				double g { get; set; }
				double b { get; set; }
			}
			public partial interface BufferAttribute_Type_2
			{
				double x { get; set; }
				double y { get; set; }
			}
			public partial interface BufferAttribute_Type_3
			{
				double x { get; set; }
				double y { get; set; }
				double z { get; set; }
			}
			public partial interface BufferAttribute_Type_4
			{
				double x { get; set; }
				double y { get; set; }
				double z { get; set; }
				double w { get; set; }
			}
			public virtual string uuid { get; set; }
			public virtual ArrayLike<double> array { get; set; }
			public virtual double itemSize { get; set; }
			public virtual bool dynamic { get; set; }
			public virtual BufferAttribute_Type_0 updateRange { get; set; }
			public virtual double version { get; set; }
			public virtual bool normalized { get; set; }
			public virtual bool needsUpdate { get; set; }
			public virtual double count { get; set; }
			public virtual Function onUpload { get; set; }
			public virtual double length { get; set; }
			public BufferAttribute(ArrayLike<double> array, double itemSize, bool normalized) { }
			public virtual void setArray(ArrayBufferView array) { }
			public virtual BufferAttribute setDynamic(bool dynamic) => default(BufferAttribute);
			public virtual BufferAttribute clone() => default(BufferAttribute);
			public virtual BufferAttribute copy(BufferAttribute source) => default(BufferAttribute);
			public virtual BufferAttribute copyAt(double index1, BufferAttribute attribute, double index2) => default(BufferAttribute);
			public virtual BufferAttribute copyArray(ArrayLike<double> array) => default(BufferAttribute);
			public virtual BufferAttribute copyColorsArray(BufferAttribute_Type_1[] colors) => default(BufferAttribute);
			public virtual BufferAttribute copyVector2sArray(BufferAttribute_Type_2[] vectors) => default(BufferAttribute);
			public virtual BufferAttribute copyVector3sArray(BufferAttribute_Type_3[] vectors) => default(BufferAttribute);
			public virtual BufferAttribute copyVector4sArray(BufferAttribute_Type_4[] vectors) => default(BufferAttribute);
			public virtual BufferAttribute set(Union<ArrayLike<double>, ArrayBufferView> value, double offset) => default(BufferAttribute);
			public virtual double getX(double index) => default(double);
			public virtual BufferAttribute setX(double index, double x) => default(BufferAttribute);
			public virtual double getY(double index) => default(double);
			public virtual BufferAttribute setY(double index, double y) => default(BufferAttribute);
			public virtual double getZ(double index) => default(double);
			public virtual BufferAttribute setZ(double index, double z) => default(BufferAttribute);
			public virtual double getW(double index) => default(double);
			public virtual BufferAttribute setW(double index, double z) => default(BufferAttribute);
			public virtual BufferAttribute setXY(double index, double x, double y) => default(BufferAttribute);
			public virtual BufferAttribute setXYZ(double index, double x, double y, double z) => default(BufferAttribute);
			public virtual BufferAttribute setXYZW(double index, double x, double y, double z, double w) => default(BufferAttribute);
			public BufferAttribute() { }
		}
		public partial class Int8Attribute : BufferAttribute
		{
			public Int8Attribute(object array, double itemSize) { }
			public Int8Attribute() { }
		}
		public partial class Uint8Attribute : BufferAttribute
		{
			public Uint8Attribute(object array, double itemSize) { }
			public Uint8Attribute() { }
		}
		public partial class Uint8ClampedAttribute : BufferAttribute
		{
			public Uint8ClampedAttribute(object array, double itemSize) { }
			public Uint8ClampedAttribute() { }
		}
		public partial class Int16Attribute : BufferAttribute
		{
			public Int16Attribute(object array, double itemSize) { }
			public Int16Attribute() { }
		}
		public partial class Uint16Attribute : BufferAttribute
		{
			public Uint16Attribute(object array, double itemSize) { }
			public Uint16Attribute() { }
		}
		public partial class Int32Attribute : BufferAttribute
		{
			public Int32Attribute(object array, double itemSize) { }
			public Int32Attribute() { }
		}
		public partial class Uint32Attribute : BufferAttribute
		{
			public Uint32Attribute(object array, double itemSize) { }
			public Uint32Attribute() { }
		}
		public partial class Float32Attribute : BufferAttribute
		{
			public Float32Attribute(object array, double itemSize) { }
			public Float32Attribute() { }
		}
		public partial class Float64Attribute : BufferAttribute
		{
			public Float64Attribute(object array, double itemSize) { }
			public Float64Attribute() { }
		}
		public partial class Int8BufferAttribute : BufferAttribute
		{
			public Int8BufferAttribute(Union<Iterable<double>, ArrayLike<double>, ArrayBuffer> array, double itemSize, bool normalized) { }
			public Int8BufferAttribute() { }
		}
		public partial class Uint8BufferAttribute : BufferAttribute
		{
			public Uint8BufferAttribute(Union<Iterable<double>, ArrayLike<double>, ArrayBuffer> array, double itemSize, bool normalized) { }
			public Uint8BufferAttribute() { }
		}
		public partial class Uint8ClampedBufferAttribute : BufferAttribute
		{
			public Uint8ClampedBufferAttribute(Union<Iterable<double>, ArrayLike<double>, ArrayBuffer> array, double itemSize, bool normalized) { }
			public Uint8ClampedBufferAttribute() { }
		}
		public partial class Int16BufferAttribute : BufferAttribute
		{
			public Int16BufferAttribute(Union<Iterable<double>, ArrayLike<double>, ArrayBuffer> array, double itemSize, bool normalized) { }
			public Int16BufferAttribute() { }
		}
		public partial class Uint16BufferAttribute : BufferAttribute
		{
			public Uint16BufferAttribute(Union<Iterable<double>, ArrayLike<double>, ArrayBuffer> array, double itemSize, bool normalized) { }
			public Uint16BufferAttribute() { }
		}
		public partial class Int32BufferAttribute : BufferAttribute
		{
			public Int32BufferAttribute(Union<Iterable<double>, ArrayLike<double>, ArrayBuffer> array, double itemSize, bool normalized) { }
			public Int32BufferAttribute() { }
		}
		public partial class Uint32BufferAttribute : BufferAttribute
		{
			public Uint32BufferAttribute(Union<Iterable<double>, ArrayLike<double>, ArrayBuffer> array, double itemSize, bool normalized) { }
			public Uint32BufferAttribute() { }
		}
		public partial class Float32BufferAttribute : BufferAttribute
		{
			public Float32BufferAttribute(Union<Iterable<double>, ArrayLike<double>, ArrayBuffer> array, double itemSize, bool normalized) { }
			public Float32BufferAttribute() { }
		}
		public partial class Float64BufferAttribute : BufferAttribute
		{
			public Float64BufferAttribute(Union<Iterable<double>, ArrayLike<double>, ArrayBuffer> array, double itemSize, bool normalized) { }
			public Float64BufferAttribute() { }
		}
		public partial class DynamicBufferAttribute : BufferAttribute
		{
			public DynamicBufferAttribute() { }
		}
		public partial class BufferGeometry : EventDispatcher
		{
			public partial interface BufferGeometry_Type_0
			{
				Union<BufferAttribute, InterleavedBufferAttribute> this[string name] { get; set; }
			}
			public partial interface BufferGeometry_Type_1
			{
				double start { get; set; }
				double count { get; set; }
				double materialIndex { get; set; }
			}
			public partial interface BufferGeometry_Type_2
			{
				double start { get; set; }
				double count { get; set; }
			}
			public partial interface BufferGeometry_Type_3
			{
				object this[string key] { get; set; }
			}
			public virtual double MaxIndex { get; set; }
			public virtual double id { get; set; }
			public virtual string uuid { get; set; }
			public virtual string name { get; set; }
			public virtual string type { get; set; }
			public virtual BufferAttribute index { get; set; }
			public virtual BufferGeometry_Type_0 attributes { get; set; }
			public virtual object morphAttributes { get; set; }
			public virtual BufferGeometry_Type_1[] groups { get; set; }
			public virtual Box3 boundingBox { get; set; }
			public virtual Sphere boundingSphere { get; set; }
			public virtual BufferGeometry_Type_2 drawRange { get; set; }
			public virtual BufferGeometry_Type_3 userData { get; set; }
			public virtual object drawcalls { get; set; }
			public virtual object offsets { get; set; }
			public BufferGeometry() { }
			public virtual BufferAttribute getIndex() => default(BufferAttribute);
			public virtual void setIndex(Union<BufferAttribute, double[]> index) { }
			public virtual BufferGeometry addAttribute(string name, Union<BufferAttribute, InterleavedBufferAttribute> attribute) => default(BufferGeometry);
			public virtual Union<BufferAttribute, InterleavedBufferAttribute> getAttribute(string name) => default(Union<BufferAttribute, InterleavedBufferAttribute>);
			public virtual BufferGeometry removeAttribute(string name) => default(BufferGeometry);
			public virtual void addGroup(double start, double count, double materialIndex) { }
			public virtual void clearGroups() { }
			public virtual void setDrawRange(double start, double count) { }
			public virtual BufferGeometry applyMatrix(Matrix4 matrix) => default(BufferGeometry);
			public virtual BufferGeometry rotateX(double angle) => default(BufferGeometry);
			public virtual BufferGeometry rotateY(double angle) => default(BufferGeometry);
			public virtual BufferGeometry rotateZ(double angle) => default(BufferGeometry);
			public virtual BufferGeometry translate(double x, double y, double z) => default(BufferGeometry);
			public virtual BufferGeometry scale(double x, double y, double z) => default(BufferGeometry);
			public virtual void lookAt(Vector3 v) { }
			public virtual BufferGeometry center() => default(BufferGeometry);
			public virtual BufferGeometry setFromObject(Object3D @object) => default(BufferGeometry);
			public virtual BufferGeometry setFromPoints(Union<Vector3[], Vector2[]> points) => default(BufferGeometry);
			public virtual void updateFromObject(Object3D @object) { }
			public virtual BufferGeometry fromGeometry(Geometry geometry, object settings) => default(BufferGeometry);
			public virtual BufferGeometry fromDirectGeometry(DirectGeometry geometry) => default(BufferGeometry);
			public virtual void computeBoundingBox() { }
			public virtual void computeBoundingSphere() { }
			public virtual void computeVertexNormals() { }
			public virtual BufferGeometry merge(BufferGeometry geometry, double offset) => default(BufferGeometry);
			public virtual void normalizeNormals() { }
			public virtual BufferGeometry toNonIndexed() => default(BufferGeometry);
			public virtual object toJSON() => default(object);
			public virtual BufferGeometry clone() => default(BufferGeometry);
			public virtual BufferGeometry copy(BufferGeometry source) => default(BufferGeometry);
			public virtual void dispose() { }
			public virtual void addIndex(object index) { }
			public virtual void addDrawCall(object start, object count, object indexOffset) { }
			public virtual void clearDrawCalls() { }
			public virtual object addAttribute(object name, object array, object itemSize) => default(object);
		}
		public partial class Clock
		{
			public virtual bool autoStart { get; set; }
			public virtual double startTime { get; set; }
			public virtual double oldTime { get; set; }
			public virtual double elapsedTime { get; set; }
			public virtual bool running { get; set; }
			public Clock(bool autoStart) { }
			public virtual void start() { }
			public virtual void stop() { }
			public virtual double getElapsedTime() => default(double);
			public virtual double getDelta() => default(double);
			public Clock() { }
		}
		public partial class DirectGeometry : EventDispatcher
		{
			public partial interface DirectGeometry_Type_0
			{
				double start { get; set; }
				double materialIndex { get; set; }
			}
			public partial interface DirectGeometry_Type_1
			{
				string type { get; set; }
				object this[string attachment] { get; set; }
			}
			public virtual double id { get; set; }
			public virtual string uuid { get; set; }
			public virtual string name { get; set; }
			public virtual string type { get; set; }
			public virtual double[] indices { get; set; }
			public virtual Vector3[] vertices { get; set; }
			public virtual Vector3[] normals { get; set; }
			public virtual Color[] colors { get; set; }
			public virtual Vector2[] uvs { get; set; }
			public virtual Vector2[] uvs2 { get; set; }
			public virtual DirectGeometry_Type_0[] groups { get; set; }
			public virtual MorphTarget[] morphTargets { get; set; }
			public virtual Vector4[] skinWeights { get; set; }
			public virtual Vector4[] skinIndices { get; set; }
			public virtual Box3 boundingBox { get; set; }
			public virtual Sphere boundingSphere { get; set; }
			public virtual bool verticesNeedUpdate { get; set; }
			public virtual bool normalsNeedUpdate { get; set; }
			public virtual bool colorsNeedUpdate { get; set; }
			public virtual bool uvsNeedUpdate { get; set; }
			public virtual bool groupsNeedUpdate { get; set; }
			public DirectGeometry() { }
			public virtual void computeBoundingBox() { }
			public virtual void computeBoundingSphere() { }
			public virtual void computeGroups(Geometry geometry) { }
			public virtual DirectGeometry fromGeometry(Geometry geometry) => default(DirectGeometry);
			public virtual void dispose() { }
			public virtual void addEventListener(string type, Action<Event> listener) { }
			public virtual bool hasEventListener(string type, Action<Event> listener) => default(bool);
			public virtual void removeEventListener(string type, Action<Event> listener) { }
			public virtual void dispatchEvent(DirectGeometry_Type_1 @event) { }
		}
		public partial class EventDispatcher
		{
			public partial interface EventDispatcher_Type_0
			{
				string type { get; set; }
				object this[string attachment] { get; set; }
			}
			public EventDispatcher() { }
			public virtual void addEventListener(string type, Action<Event> listener) { }
			public virtual bool hasEventListener(string type, Action<Event> listener) => default(bool);
			public virtual void removeEventListener(string type, Action<Event> listener) { }
			public virtual void dispatchEvent(EventDispatcher_Type_0 @event) { }
		}
		public partial interface Event
		{
			string type { get; set; }
			object target { get; set; }
			object this[string attachment] { get; set; }
		}
		public partial class Face3
		{
			public virtual double a { get; set; }
			public virtual double b { get; set; }
			public virtual double c { get; set; }
			public virtual Vector3 normal { get; set; }
			public virtual Vector3[] vertexNormals { get; set; }
			public virtual Color color { get; set; }
			public virtual Color[] vertexColors { get; set; }
			public virtual double materialIndex { get; set; }
			public Face3(double a, double b, double c, Vector3 normal, Color color, double materialIndex) { }
			public Face3(double a, double b, double c, Vector3 normal, Color[] vertexColors, double materialIndex) { }
			public Face3(double a, double b, double c, Vector3[] vertexNormals, Color color, double materialIndex) { }
			public Face3(double a, double b, double c, Vector3[] vertexNormals, Color[] vertexColors, double materialIndex) { }
			public virtual Face3 clone() => default(Face3);
			public virtual Face3 copy(Face3 source) => default(Face3);
			public Face3() { }
		}
		public partial class Face4 : Face3
		{
			public Face4() { }
		}
		public partial interface MorphTarget
		{
			string name { get; set; }
			Vector3[] vertices { get; set; }
		}
		public partial interface MorphColor
		{
			string name { get; set; }
			Color[] colors { get; set; }
		}
		public partial interface MorphNormals
		{
			string name { get; set; }
			Vector3[] normals { get; set; }
		}
		public virtual double GeometryIdCount { get; set; }
		public partial class Geometry : EventDispatcher
		{
			public partial interface Geometry_Type_0
			{
				string type { get; set; }
				object this[string attachment] { get; set; }
			}
			public virtual double id { get; set; }
			public virtual string uuid { get; set; }
			public virtual string name { get; set; }
			public virtual string type { get; set; }
			public virtual Vector3[] vertices { get; set; }
			public virtual Color[] colors { get; set; }
			public virtual Face3[] faces { get; set; }
			public virtual Vector2[][][] faceVertexUvs { get; set; }
			public virtual MorphTarget[] morphTargets { get; set; }
			public virtual MorphNormals[] morphNormals { get; set; }
			public virtual Vector4[] skinWeights { get; set; }
			public virtual Vector4[] skinIndices { get; set; }
			public virtual double[] lineDistances { get; set; }
			public virtual Box3 boundingBox { get; set; }
			public virtual Sphere boundingSphere { get; set; }
			public virtual bool verticesNeedUpdate { get; set; }
			public virtual bool elementsNeedUpdate { get; set; }
			public virtual bool uvsNeedUpdate { get; set; }
			public virtual bool normalsNeedUpdate { get; set; }
			public virtual bool colorsNeedUpdate { get; set; }
			public virtual bool lineDistancesNeedUpdate { get; set; }
			public virtual bool groupsNeedUpdate { get; set; }
			public virtual Bone[] bones { get; set; }
			public virtual AnimationClip animation { get; set; }
			public virtual AnimationClip[] animations { get; set; }
			public Geometry() { }
			public virtual Geometry applyMatrix(Matrix4 matrix) => default(Geometry);
			public virtual Geometry rotateX(double angle) => default(Geometry);
			public virtual Geometry rotateY(double angle) => default(Geometry);
			public virtual Geometry rotateZ(double angle) => default(Geometry);
			public virtual Geometry translate(double x, double y, double z) => default(Geometry);
			public virtual Geometry scale(double x, double y, double z) => default(Geometry);
			public virtual void lookAt(Vector3 vector) { }
			public virtual Geometry fromBufferGeometry(BufferGeometry geometry) => default(Geometry);
			public virtual Geometry center() => default(Geometry);
			public virtual Geometry normalize() => default(Geometry);
			public virtual void computeFaceNormals() { }
			public virtual void computeVertexNormals(bool areaWeighted) { }
			public virtual void computeFlatVertexNormals() { }
			public virtual void computeMorphNormals() { }
			public virtual void computeBoundingBox() { }
			public virtual void computeBoundingSphere() { }
			public virtual void merge(Geometry geometry, Matrix matrix, double materialIndexOffset) { }
			public virtual void mergeMesh(Mesh mesh) { }
			public virtual double mergeVertices() => default(double);
			public virtual Geometry setFromPoints(Union<Vector2[], Vector3[]> points) => default(Geometry);
			public virtual void sortFacesByMaterialIndex() { }
			public virtual object toJSON() => default(object);
			public virtual Geometry clone() => default(Geometry);
			public virtual Geometry copy(Geometry source) => default(Geometry);
			public virtual void dispose() { }
			public virtual void addEventListener(string type, Action<Event> listener) { }
			public virtual bool hasEventListener(string type, Action<Event> listener) => default(bool);
			public virtual void removeEventListener(string type, Action<Event> listener) { }
			public virtual void dispatchEvent(Geometry_Type_0 @event) { }
		}
		public partial class BufferGeometryUtils
		{
			public virtual BufferGeometry mergeBufferGeometries(BufferGeometry[] geometries) => default(BufferGeometry);
			public virtual object computeTangents(BufferGeometry geometry) => default(object);
			public virtual BufferAttribute mergeBufferAttributes(BufferAttribute[] attributes) => default(BufferAttribute);
			public BufferGeometryUtils() { }
		}
		public partial class GeometryUtils
		{
			public virtual object merge(object geometry1, object geometry2, object materialIndexOffset) => default(object);
			public virtual object center(object geometry) => default(object);
			public GeometryUtils() { }
		}
		public partial class InstancedBufferAttribute : BufferAttribute
		{
			public virtual double meshPerAttribute { get; set; }
			public InstancedBufferAttribute(ArrayLike<double> data, double itemSize, double meshPerAttribute) { }
			public InstancedBufferAttribute() { }
		}
		public partial class InstancedBufferGeometry : BufferGeometry
		{
			public partial interface InstancedBufferGeometry_Type_0
			{
				double start { get; set; }
				double count { get; set; }
				double instances { get; set; }
			}
			public virtual InstancedBufferGeometry_Type_0[] groups { get; set; }
			public virtual double maxInstancedCount { get; set; }
			public InstancedBufferGeometry() { }
			public virtual void addGroup(double start, double count, double instances) { }
		}
		public partial class InterleavedBuffer
		{
			public partial interface InterleavedBuffer_Type_0
			{
				double offset { get; set; }
				double count { get; set; }
			}
			public virtual ArrayLike<double> array { get; set; }
			public virtual double stride { get; set; }
			public virtual bool dynamic { get; set; }
			public virtual InterleavedBuffer_Type_0 updateRange { get; set; }
			public virtual double version { get; set; }
			public virtual double length { get; set; }
			public virtual double count { get; set; }
			public virtual bool needsUpdate { get; set; }
			public InterleavedBuffer(ArrayLike<double> array, double stride) { }
			public virtual void setArray(ArrayBufferView array) { }
			public virtual InterleavedBuffer setDynamic(bool dynamic) => default(InterleavedBuffer);
			public virtual InterleavedBuffer clone() => default(InterleavedBuffer);
			public virtual InterleavedBuffer copy(InterleavedBuffer source) => default(InterleavedBuffer);
			public virtual InterleavedBuffer copyAt(double index1, InterleavedBufferAttribute attribute, double index2) => default(InterleavedBuffer);
			public virtual InterleavedBuffer set(ArrayLike<double> value, double index) => default(InterleavedBuffer);
			public InterleavedBuffer() { }
		}
		public partial class InstancedInterleavedBuffer : InterleavedBuffer
		{
			public virtual double meshPerAttribute { get; set; }
			public InstancedInterleavedBuffer(ArrayLike<double> array, double stride, double meshPerAttribute) { }
			public InstancedInterleavedBuffer() { }
		}
		public partial class InterleavedBufferAttribute
		{
			public virtual string uuid { get; set; }
			public virtual InterleavedBuffer data { get; set; }
			public virtual double itemSize { get; set; }
			public virtual double offset { get; set; }
			public virtual double count { get; set; }
			public virtual bool normalized { get; set; }
			public virtual object[] array { get; set; }
			public virtual double length { get; set; }
			public InterleavedBufferAttribute(InterleavedBuffer interleavedBuffer, double itemSize, double offset, bool normalized) { }
			public virtual double getX(double index) => default(double);
			public virtual InterleavedBufferAttribute setX(double index, double x) => default(InterleavedBufferAttribute);
			public virtual double getY(double index) => default(double);
			public virtual InterleavedBufferAttribute setY(double index, double y) => default(InterleavedBufferAttribute);
			public virtual double getZ(double index) => default(double);
			public virtual InterleavedBufferAttribute setZ(double index, double z) => default(InterleavedBufferAttribute);
			public virtual double getW(double index) => default(double);
			public virtual InterleavedBufferAttribute setW(double index, double z) => default(InterleavedBufferAttribute);
			public virtual InterleavedBufferAttribute setXY(double index, double x, double y) => default(InterleavedBufferAttribute);
			public virtual InterleavedBufferAttribute setXYZ(double index, double x, double y, double z) => default(InterleavedBufferAttribute);
			public virtual InterleavedBufferAttribute setXYZW(double index, double x, double y, double z, double w) => default(InterleavedBufferAttribute);
			public InterleavedBufferAttribute() { }
		}
		public virtual double Object3DIdCount { get; set; }
		public partial class Object3D : EventDispatcher
		{
			public partial interface Object3D_Type_0
			{
				object this[string key] { get; set; }
			}
			public partial interface Object3D_Type_1
			{
				object geometries { get; set; }
				object materials { get; set; }
				object textures { get; set; }
				object images { get; set; }
			}
			public virtual double id { get; set; }
			public virtual string uuid { get; set; }
			public virtual string name { get; set; }
			public virtual string type { get; set; }
			public virtual Union<Object3D, object> parent { get; set; }
			public virtual Object3D[] children { get; set; }
			public virtual Vector3 up { get; set; }
			public virtual Vector3 position { get; set; }
			public virtual Euler rotation { get; set; }
			public virtual Quaternion quaternion { get; set; }
			public virtual Vector3 scale { get; set; }
			public virtual Matrix4 modelViewMatrix { get; set; }
			public virtual Matrix3 normalMatrix { get; set; }
			public virtual Matrix4 matrix { get; set; }
			public virtual Matrix4 matrixWorld { get; set; }
			public virtual bool matrixAutoUpdate { get; set; }
			public virtual bool matrixWorldNeedsUpdate { get; set; }
			public virtual Layers layers { get; set; }
			public virtual bool visible { get; set; }
			public virtual bool castShadow { get; set; }
			public virtual bool receiveShadow { get; set; }
			public virtual bool frustumCulled { get; set; }
			public virtual double renderOrder { get; set; }
			public virtual Object3D_Type_0 userData { get; set; }
			public virtual bool isObject3D { get; set; }
			public virtual Action<WebGLRenderer, Scene, Camera, Union<Geometry, BufferGeometry>, Material, Group> onBeforeRender { get; set; }
			public virtual Action<WebGLRenderer, Scene, Camera, Union<Geometry, BufferGeometry>, Material, Group> onAfterRender { get; set; }
			public virtual Vector3 DefaultUp { get; set; }
			public virtual bool DefaultMatrixAutoUpdate { get; set; }
			public Object3D() { }
			public virtual void applyMatrix(Matrix4 matrix) { }
			public virtual Object3D applyQuaternion(Quaternion quaternion) => default(Object3D);
			public virtual void setRotationFromAxisAngle(Vector3 axis, double angle) { }
			public virtual void setRotationFromEuler(Euler euler) { }
			public virtual void setRotationFromMatrix(Matrix4 m) { }
			public virtual void setRotationFromQuaternion(Quaternion q) { }
			public virtual Object3D rotateOnAxis(Vector3 axis, double angle) => default(Object3D);
			public virtual Object3D rotateOnWorldAxis(Vector3 axis, double angle) => default(Object3D);
			public virtual Object3D rotateX(double angle) => default(Object3D);
			public virtual Object3D rotateY(double angle) => default(Object3D);
			public virtual Object3D rotateZ(double angle) => default(Object3D);
			public virtual Object3D translateOnAxis(Vector3 axis, double distance) => default(Object3D);
			public virtual Object3D translateX(double distance) => default(Object3D);
			public virtual Object3D translateY(double distance) => default(Object3D);
			public virtual Object3D translateZ(double distance) => default(Object3D);
			public virtual Vector3 localToWorld(Vector3 vector) => default(Vector3);
			public virtual Vector3 worldToLocal(Vector3 vector) => default(Vector3);
			public virtual void lookAt(Union<Vector3, double> vector, double y, double z) { }
			public virtual Object3D add(Union<Object3D, Object3D[]> @object) => default(Object3D);
			public virtual Object3D remove(Object3D[] @object) => default(Object3D);
			public virtual Union<Object3D, undefined> getObjectById(double id) => default(Union<Object3D, undefined>);
			public virtual Union<Object3D, undefined> getObjectByName(string name) => default(Union<Object3D, undefined>);
			public virtual Union<Object3D, undefined> getObjectByProperty(string name, string value) => default(Union<Object3D, undefined>);
			public virtual Vector3 getWorldPosition(Vector3 target) => default(Vector3);
			public virtual Quaternion getWorldQuaternion(Quaternion target) => default(Quaternion);
			public virtual Vector3 getWorldScale(Vector3 target) => default(Vector3);
			public virtual Vector3 getWorldDirection(Vector3 target) => default(Vector3);
			public virtual void raycast(Raycaster raycaster, Intersection[] intersects) { }
			public virtual void traverse(Func<Object3D, object> callback) { }
			public virtual void traverseVisible(Func<Object3D, object> callback) { }
			public virtual void traverseAncestors(Func<Object3D, object> callback) { }
			public virtual void updateMatrix() { }
			public virtual void updateMatrixWorld(bool force) { }
			public virtual void updateWorldMatrix(bool updateParents, bool updateChildren) { }
			public virtual object toJSON(Object3D_Type_1 meta) => default(object);
			public virtual Object3D clone(bool recursive) => default(Object3D);
			public virtual Object3D copy(Object3D source, bool recursive) => default(Object3D);
		}
		public partial interface Intersection
		{
			double distance { get; set; }
			double distanceToRay { get; set; }
			Vector3 point { get; set; }
			double index { get; set; }
			Union<Face3, object> face { get; set; }
			double faceIndex { get; set; }
			Object3D @object { get; set; }
			Vector2 uv { get; set; }
		}
		public partial interface RaycasterParameters
		{
			object Mesh { get; set; }
			object Line { get; set; }
			object LOD { get; set; }
			RaycasterParameters_Type_0 Points { get; set; }
			object Sprite { get; set; }
		}
		public partial interface RaycasterParameters_Type_0
		{
			double threshold { get; set; }
		}
		public partial class Raycaster
		{
			public partial interface Raycaster_Type_0
			{
				double x { get; set; }
				double y { get; set; }
			}
			public virtual Ray ray { get; set; }
			public virtual double near { get; set; }
			public virtual double far { get; set; }
			public virtual RaycasterParameters @params { get; set; }
			public virtual double linePrecision { get; set; }
			public Raycaster(Vector3 origin, Vector3 direction, double near, double far) { }
			public virtual void set(Vector3 origin, Vector3 direction) { }
			public virtual void setFromCamera(Raycaster_Type_0 coords, Camera camera) { }
			public virtual Intersection[] intersectObject(Object3D @object, bool recursive, Intersection[] optionalTarget) => default(Intersection[]);
			public virtual Intersection[] intersectObjects(Object3D[] objects, bool recursive, Intersection[] optionalTarget) => default(Intersection[]);
			public Raycaster() { }
		}
		public partial class Layers
		{
			public virtual double mask { get; set; }
			public Layers() { }
			public virtual void set(double channel) { }
			public virtual void enable(double channel) { }
			public virtual void toggle(double channel) { }
			public virtual void disable(double channel) { }
			public virtual bool test(Layers layers) => default(bool);
		}
		public partial class Font
		{
			public virtual string data { get; set; }
			public Font(object jsondata) { }
			public virtual object[] generateShapes(string text, double size, double divisions) => default(object[]);
			public Font() { }
		}
		public partial class Light : Object3D
		{
			public virtual Color color { get; set; }
			public virtual double intensity { get; set; }
			public virtual bool receiveShadow { get; set; }
			public virtual LightShadow shadow { get; set; }
			public virtual object shadowCameraFov { get; set; }
			public virtual object shadowCameraLeft { get; set; }
			public virtual object shadowCameraRight { get; set; }
			public virtual object shadowCameraTop { get; set; }
			public virtual object shadowCameraBottom { get; set; }
			public virtual object shadowCameraNear { get; set; }
			public virtual object shadowCameraFar { get; set; }
			public virtual object shadowBias { get; set; }
			public virtual object shadowMapWidth { get; set; }
			public virtual object shadowMapHeight { get; set; }
			public Light(Union<double, string> hex, double intensity) { }
			public Light() { }
		}
		public partial class LightShadow
		{
			public virtual Camera camera { get; set; }
			public virtual double bias { get; set; }
			public virtual double radius { get; set; }
			public virtual Vector2 mapSize { get; set; }
			public virtual RenderTarget map { get; set; }
			public virtual Matrix4 matrix { get; set; }
			public LightShadow(Camera camera) { }
			public virtual LightShadow copy(LightShadow source) => default(LightShadow);
			public virtual LightShadow clone(bool recursive) => default(LightShadow);
			public virtual object toJSON() => default(object);
			public LightShadow() { }
		}
		public partial class AmbientLight : Light
		{
			public virtual bool castShadow { get; set; }
			public AmbientLight(Union<Color, string, double> color, double intensity) { }
			public AmbientLight() { }
		}
		public partial class DirectionalLight : Light
		{
			public virtual Object3D target { get; set; }
			public virtual double intensity { get; set; }
			public virtual DirectionalLightShadow shadow { get; set; }
			public DirectionalLight(Union<Color, string, double> color, double intensity) { }
			public DirectionalLight() { }
		}
		public partial class DirectionalLightShadow : LightShadow
		{
			public virtual OrthographicCamera camera { get; set; }
			public DirectionalLightShadow() { }
		}
		public partial class HemisphereLight : Light
		{
			public virtual Color skyColor { get; set; }
			public virtual Color groundColor { get; set; }
			public virtual double intensity { get; set; }
			public HemisphereLight(Union<Color, string, double> skyColor, Union<Color, string, double> groundColor, double intensity) { }
			public HemisphereLight() { }
		}
		public partial class PointLight : Light
		{
			public virtual double intensity { get; set; }
			public virtual double distance { get; set; }
			public virtual double decay { get; set; }
			public virtual PointLightShadow shadow { get; set; }
			public virtual double power { get; set; }
			public PointLight(Union<Color, string, double> color, double intensity, double distance, double decay) { }
			public PointLight() { }
		}
		public partial class PointLightShadow : LightShadow
		{
			public virtual PerspectiveCamera camera { get; set; }
			public PointLightShadow() { }
		}
		public partial class SpotLight : Light
		{
			public virtual Object3D target { get; set; }
			public virtual double intensity { get; set; }
			public virtual double distance { get; set; }
			public virtual double angle { get; set; }
			public virtual double exponent { get; set; }
			public virtual double decay { get; set; }
			public virtual SpotLightShadow shadow { get; set; }
			public virtual double power { get; set; }
			public virtual double penumbra { get; set; }
			public SpotLight(Union<Color, string, double> color, double intensity, double distance, double angle, double exponent, double decay) { }
			public SpotLight() { }
		}
		public partial class SpotLightShadow : LightShadow
		{
			public virtual PerspectiveCamera camera { get; set; }
			public virtual void update(Light light) { }
			public SpotLightShadow() { }
		}
		public partial class Loader
		{
			public virtual Action onLoadStart { get; set; }
			public virtual Action onLoadProgress { get; set; }
			public virtual Action onLoadComplete { get; set; }
			public virtual string crossOrigin { get; set; }
			public virtual LoaderHandler Handlers { get; set; }
			public Loader() { }
			public virtual string extractUrlBase(string url) => default(string);
			public virtual Material[] initMaterials(Material[] materials, string texturePath) => default(Material[]);
			public virtual bool createMaterial(Material m, string texturePath, string crossOrigin) => default(bool);
		}
		public partial interface AnyLoader
		{
			object load(string url, Action<object> onLoad, Action<ProgressEvent> onProgress, Action<ErrorEvent> onError);
		}
		public partial interface LoaderHandler
		{
			Union<RegExp, AnyLoader>[] handlers { get; set; }
			void add(RegExp regex, AnyLoader loader);
			Union<AnyLoader, object> get(string file);
		}
		public partial class FileLoader
		{
			public partial interface FileLoader_Type_0
			{
				string this[string header] { get; set; }
			}
			public virtual LoadingManager manager { get; set; }
			public virtual MimeType mimeType { get; set; }
			public virtual string path { get; set; }
			public virtual string responseType { get; set; }
			public virtual string withCredentials { get; set; }
			public FileLoader(LoadingManager manager) { }
			public virtual object load(string url, Action<Union<string, ArrayBuffer>> onLoad, Action<ProgressEvent> onProgress, Action<ErrorEvent> onError) => default(object);
			public virtual FileLoader setMimeType(MimeType mimeType) => default(FileLoader);
			public virtual FileLoader setPath(string path) => default(FileLoader);
			public virtual FileLoader setResponseType(string responseType) => default(FileLoader);
			public virtual FileLoader setWithCredentials(string value) => default(FileLoader);
			public virtual FileLoader setRequestHeader(FileLoader_Type_0 value) => default(FileLoader);
			public FileLoader() { }
		}
		public partial class FontLoader
		{
			public virtual LoadingManager manager { get; set; }
			public FontLoader(LoadingManager manager) { }
			public virtual void load(string url, Action<Font> onLoad, Action<ProgressEvent> onProgress, Action<ErrorEvent> onError) { }
			public virtual Font parse(object json) => default(Font);
			public FontLoader() { }
		}
		public partial class ImageLoader
		{
			public virtual LoadingManager manager { get; set; }
			public virtual string crossOrigin { get; set; }
			public virtual string withCredentials { get; set; }
			public virtual string path { get; set; }
			public ImageLoader(LoadingManager manager) { }
			public virtual HTMLImageElement load(string url, Action<HTMLImageElement> onLoad, Action<ProgressEvent> onProgress, Action<ErrorEvent> onError) => default(HTMLImageElement);
			public virtual ImageLoader setCrossOrigin(string crossOrigin) => default(ImageLoader);
			public virtual ImageLoader setWithCredentials(string value) => default(ImageLoader);
			public virtual ImageLoader setPath(string value) => default(ImageLoader);
			public ImageLoader() { }
		}
		public partial class JSONLoader : Loader
		{
			public partial interface JSONLoader_Type_0
			{
				Geometry geometry { get; set; }
				Material[] materials { get; set; }
			}
			public virtual LoadingManager manager { get; set; }
			public virtual bool withCredentials { get; set; }
			public JSONLoader(LoadingManager manager) { }
			public virtual void load(string url, Action<Geometry, Material[]> onLoad, Action<ProgressEvent> onProgress, Action<ErrorEvent> onError) { }
			public virtual void setTexturePath(string value) { }
			public virtual JSONLoader_Type_0 parse(object json, string texturePath) => default(JSONLoader_Type_0);
			public JSONLoader() { }
		}
		public partial class LoadingManager
		{
			public virtual Action<string, double, double> onStart { get; set; }
			public virtual Action onLoad { get; set; }
			public virtual Action<object, double, double> onProgress { get; set; }
			public virtual Action<string> onError { get; set; }
			public LoadingManager(Action onLoad, Action<string, double, double> onProgress, Action<string> onError) { }
			public virtual void setURLModifier(Func<string, string> callback) { }
			public virtual string resolveURL(string url) => default(string);
			public virtual void itemStart(string url) { }
			public virtual void itemEnd(string url) { }
			public virtual void itemError(string url) { }
			public LoadingManager() { }
		}
		public virtual LoadingManager DefaultLoadingManager { get; set; }
		public partial class BufferGeometryLoader
		{
			public virtual LoadingManager manager { get; set; }
			public BufferGeometryLoader(LoadingManager manager) { }
			public virtual void load(string url, Action<BufferGeometry> onLoad, Action<object> onProgress, Action<object> onError) { }
			public virtual BufferGeometry parse(object json) => default(BufferGeometry);
			public BufferGeometryLoader() { }
		}
		public partial class MaterialLoader
		{
			public partial interface MaterialLoader_Type_0
			{
				Texture this[string key] { get; set; }
			}
			public partial interface MaterialLoader_Type_1
			{
				Texture this[string key] { get; set; }
			}
			public virtual LoadingManager manager { get; set; }
			public virtual MaterialLoader_Type_0 textures { get; set; }
			public MaterialLoader(LoadingManager manager) { }
			public virtual void load(string url, Action<Material> onLoad, Action<ProgressEvent> onProgress, Action<Union<Error, ErrorEvent>> onError) { }
			public virtual void setTextures(MaterialLoader_Type_1 textures) { }
			public virtual Texture getTexture(string name) => default(Texture);
			public virtual Material parse(object json) => default(Material);
			public MaterialLoader() { }
		}
		public partial class ObjectLoader
		{
			public partial interface ObjectLoader_Type_0
			{
				HTMLImageElement this[string key] { get; set; }
			}
			public virtual LoadingManager manager { get; set; }
			public virtual string texturePass { get; set; }
			public virtual string crossOrigin { get; set; }
			public ObjectLoader(LoadingManager manager) { }
			public virtual void load(string url, Action<Object3D> onLoad, Action<ProgressEvent> onProgress, Action<Union<Error, ErrorEvent>> onError) { }
			public virtual void setTexturePath(string value) { }
			public virtual void setCrossOrigin(string crossOrigin) { }
			public virtual T parse<T>(object json, Action<Object3D> onLoad) => default(T);
			public virtual object[] parseGeometries(object json) => default(object[]);
			public virtual Material[] parseMaterials(object json, Texture[] textures) => default(Material[]);
			public virtual AnimationClip[] parseAnimations(object json) => default(AnimationClip[]);
			public virtual ObjectLoader_Type_0 parseImages(object json, Action onLoad) => default(ObjectLoader_Type_0);
			public virtual Texture[] parseTextures(object json, object images) => default(Texture[]);
			public virtual T parseObject<T>(object data, object[] geometries, Material[] materials) => default(T);
			public ObjectLoader() { }
		}
		public partial class TextureLoader
		{
			public virtual LoadingManager manager { get; set; }
			public virtual string crossOrigin { get; set; }
			public virtual string withCredentials { get; set; }
			public virtual string path { get; set; }
			public TextureLoader(LoadingManager manager) { }
			public virtual Texture load(string url, Action<Texture> onLoad, Action<ProgressEvent> onProgress, Action<ErrorEvent> onError) => default(Texture);
			public virtual TextureLoader setCrossOrigin(string crossOrigin) => default(TextureLoader);
			public virtual TextureLoader setWithCredentials(string value) => default(TextureLoader);
			public virtual TextureLoader setPath(string path) => default(TextureLoader);
			public TextureLoader() { }
		}
		public partial class CubeTextureLoader
		{
			public virtual LoadingManager manager { get; set; }
			public virtual string crossOrigin { get; set; }
			public virtual string path { get; set; }
			public CubeTextureLoader(LoadingManager manager) { }
			public virtual CubeTexture load(string[] urls, Action<CubeTexture> onLoad, Action<ProgressEvent> onProgress, Action<ErrorEvent> onError) => default(CubeTexture);
			public virtual CubeTextureLoader setCrossOrigin(string crossOrigin) => default(CubeTextureLoader);
			public virtual CubeTextureLoader setPath(string path) => default(CubeTextureLoader);
			public CubeTextureLoader() { }
		}
		public partial class DataTextureLoader
		{
			public virtual LoadingManager manager { get; set; }
			public DataTextureLoader(LoadingManager manager) { }
			public virtual void load(string url, Action<DataTexture> onLoad, Action<ProgressEvent> onProgress, Action<ErrorEvent> onError) { }
			public DataTextureLoader() { }
		}
		public partial class BinaryTextureLoader : DataTextureLoader
		{
			public BinaryTextureLoader() { }
		}
		public partial class CompressedTextureLoader
		{
			public virtual LoadingManager manager { get; set; }
			public virtual string path { get; set; }
			public CompressedTextureLoader(LoadingManager manager) { }
			public virtual void load(string url, Action<CompressedTexture> onLoad, Action<ProgressEvent> onProgress, Action<ErrorEvent> onError) { }
			public virtual CompressedTextureLoader setPath(string path) => default(CompressedTextureLoader);
			public CompressedTextureLoader() { }
		}
		public partial class AudioLoader
		{
			public AudioLoader(LoadingManager manager) { }
			public virtual void load(string url, Function onLoad, Function onPrgress, Function onError) { }
			public AudioLoader() { }
		}
		public partial class Cache
		{
			public virtual bool enabled { get; set; }
			public virtual object files { get; set; }
			public virtual void add(string key, object file) { }
			public virtual object get(string key) => default(object);
			public virtual void remove(string key) { }
			public virtual void clear() { }
			public Cache() { }
		}
		public partial class LoaderUtils
		{
			public virtual string decodeText(TypedArray array) => default(string);
			public virtual string extractUrlBase(string url) => default(string);
			public LoaderUtils() { }
		}
		public virtual double MaterialIdCount { get; set; }
		public partial interface MaterialParameters
		{
			double alphaTest { get; set; }
			BlendingDstFactor blendDst { get; set; }
			double blendDstAlpha { get; set; }
			BlendingEquation blendEquation { get; set; }
			double blendEquationAlpha { get; set; }
			Blending blending { get; set; }
			Union<BlendingSrcFactor, BlendingDstFactor> blendSrc { get; set; }
			double blendSrcAlpha { get; set; }
			bool clipIntersection { get; set; }
			Plane[] clippingPlanes { get; set; }
			bool clipShadows { get; set; }
			bool colorWrite { get; set; }
			DepthModes depthFunc { get; set; }
			bool depthTest { get; set; }
			bool depthWrite { get; set; }
			bool fog { get; set; }
			bool lights { get; set; }
			string name { get; set; }
			double opacity { get; set; }
			double overdraw { get; set; }
			bool polygonOffset { get; set; }
			double polygonOffsetFactor { get; set; }
			double polygonOffsetUnits { get; set; }
			MaterialParameters_Type_0 precision { get; set; }
			bool premultipliedAlpha { get; set; }
			bool dithering { get; set; }
			bool flatShading { get; set; }
			Side side { get; set; }
			bool transparent { get; set; }
			Colors vertexColors { get; set; }
			bool visible { get; set; }
		}
		public class MaterialParameters_Type_0 : Enumerated
		{
			public static string highp = "highp";
			public static string mediump = "mediump";
			public static string lowp = "lowp";
			public static implicit operator MaterialParameters_Type_0(string value) { return new MaterialParameters_Type_0(value); }
			public MaterialParameters_Type_0(object value) { Value = value; }
		}
		public partial class Material : EventDispatcher
		{
			public class Material_Type_0 : Enumerated
			{
				public static string highp = "highp";
				public static string mediump = "mediump";
				public static string lowp = "lowp";
				public static implicit operator Material_Type_0(string value) { return new Material_Type_0(value); }
				public Material_Type_0(object value) { Value = value; }
			}
			public virtual double alphaTest { get; set; }
			public virtual BlendingDstFactor blendDst { get; set; }
			public virtual Union<double, object> blendDstAlpha { get; set; }
			public virtual BlendingEquation blendEquation { get; set; }
			public virtual Union<double, object> blendEquationAlpha { get; set; }
			public virtual Blending blending { get; set; }
			public virtual Union<BlendingSrcFactor, BlendingDstFactor> blendSrc { get; set; }
			public virtual Union<double, object> blendSrcAlpha { get; set; }
			public virtual bool clipIntersection { get; set; }
			public virtual object clippingPlanes { get; set; }
			public virtual bool clipShadows { get; set; }
			public virtual bool colorWrite { get; set; }
			public virtual DepthModes depthFunc { get; set; }
			public virtual bool depthTest { get; set; }
			public virtual bool depthWrite { get; set; }
			public virtual bool fog { get; set; }
			public virtual double id { get; set; }
			public virtual bool isMaterial { get; set; }
			public virtual bool lights { get; set; }
			public virtual string name { get; set; }
			public virtual bool needsUpdate { get; set; }
			public virtual double opacity { get; set; }
			public virtual double overdraw { get; set; }
			public virtual bool polygonOffset { get; set; }
			public virtual double polygonOffsetFactor { get; set; }
			public virtual double polygonOffsetUnits { get; set; }
			public virtual Material_Type_0 precision { get; set; }
			public virtual bool premultipliedAlpha { get; set; }
			public virtual bool dithering { get; set; }
			public virtual bool flatShading { get; set; }
			public virtual Side side { get; set; }
			public virtual bool transparent { get; set; }
			public virtual string type { get; set; }
			public virtual string uuid { get; set; }
			public virtual Colors vertexColors { get; set; }
			public virtual bool visible { get; set; }
			public virtual object userData { get; set; }
			public Material() { }
			public virtual Material clone() => default(Material);
			public virtual Material copy(Material material) => default(Material);
			public virtual void dispose() { }
			public virtual void setValues(MaterialParameters values) { }
			public virtual object toJSON(object meta) => default(object);
			public virtual void update() { }
		}
		public partial interface LineBasicMaterialParameters : MaterialParameters
		{
			Union<Color, string, double> color { get; set; }
			double linewidth { get; set; }
			string linecap { get; set; }
			string linejoin { get; set; }
		}
		public partial class LineBasicMaterial : Material
		{
			public virtual Color color { get; set; }
			public virtual double linewidth { get; set; }
			public virtual string linecap { get; set; }
			public virtual string linejoin { get; set; }
			public LineBasicMaterial(LineBasicMaterialParameters parameters) { }
			public virtual void setValues(LineBasicMaterialParameters parameters) { }
			public LineBasicMaterial() { }
		}
		public partial interface LineDashedMaterialParameters : MaterialParameters
		{
			Union<Color, string, double> color { get; set; }
			double linewidth { get; set; }
			double scale { get; set; }
			double dashSize { get; set; }
			double gapSize { get; set; }
		}
		public partial class LineDashedMaterial : LineBasicMaterial
		{
			public virtual double scale { get; set; }
			public virtual double dashSize { get; set; }
			public virtual double gapSize { get; set; }
			public virtual bool isLineDashedMaterial { get; set; }
			public LineDashedMaterial(LineDashedMaterialParameters parameters) { }
			public virtual void setValues(LineDashedMaterialParameters parameters) { }
			public LineDashedMaterial() { }
		}
		public partial interface MeshBasicMaterialParameters : MaterialParameters
		{
			Union<Color, string, double> color { get; set; }
			double opacity { get; set; }
			Texture map { get; set; }
			Texture aoMap { get; set; }
			double aoMapIntensity { get; set; }
			Texture specularMap { get; set; }
			Texture alphaMap { get; set; }
			Texture envMap { get; set; }
			Combine combine { get; set; }
			double reflectivity { get; set; }
			double refractionRatio { get; set; }
			bool wireframe { get; set; }
			double wireframeLinewidth { get; set; }
			string wireframeLinecap { get; set; }
			string wireframeLinejoin { get; set; }
			bool skinning { get; set; }
			bool morphTargets { get; set; }
		}
		public partial class MeshBasicMaterial : Material
		{
			public virtual Color color { get; set; }
			public virtual Union<Texture, object> map { get; set; }
			public virtual Union<Texture, object> aoMap { get; set; }
			public virtual double aoMapIntensity { get; set; }
			public virtual Union<Texture, object> specularMap { get; set; }
			public virtual Union<Texture, object> alphaMap { get; set; }
			public virtual Union<Texture, object> envMap { get; set; }
			public virtual Combine combine { get; set; }
			public virtual double reflectivity { get; set; }
			public virtual double refractionRatio { get; set; }
			public virtual bool wireframe { get; set; }
			public virtual double wireframeLinewidth { get; set; }
			public virtual string wireframeLinecap { get; set; }
			public virtual string wireframeLinejoin { get; set; }
			public virtual bool skinning { get; set; }
			public virtual bool morphTargets { get; set; }
			public MeshBasicMaterial(MeshBasicMaterialParameters parameters) { }
			public virtual void setValues(MeshBasicMaterialParameters parameters) { }
			public MeshBasicMaterial() { }
		}
		public partial interface MeshDepthMaterialParameters : MaterialParameters
		{
			bool wireframe { get; set; }
			double wireframeLinewidth { get; set; }
		}
		public partial class MeshDepthMaterial : Material
		{
			public virtual bool wireframe { get; set; }
			public virtual double wireframeLinewidth { get; set; }
			public virtual DepthPackingStrategies depthPacking { get; set; }
			public MeshDepthMaterial(MeshDepthMaterialParameters parameters) { }
			public virtual void setValues(MeshDepthMaterialParameters parameters) { }
			public MeshDepthMaterial() { }
		}
		public partial interface MeshLambertMaterialParameters : MaterialParameters
		{
			Union<Color, string, double> color { get; set; }
			Union<Color, string, double> emissive { get; set; }
			double emissiveIntensity { get; set; }
			Texture emissiveMap { get; set; }
			Texture map { get; set; }
			Texture lightMap { get; set; }
			double lightMapIntensity { get; set; }
			Texture aoMap { get; set; }
			double aoMapIntensity { get; set; }
			Texture specularMap { get; set; }
			Texture alphaMap { get; set; }
			Texture envMap { get; set; }
			Combine combine { get; set; }
			double reflectivity { get; set; }
			double refractionRatio { get; set; }
			bool wireframe { get; set; }
			double wireframeLinewidth { get; set; }
			string wireframeLinecap { get; set; }
			string wireframeLinejoin { get; set; }
			bool skinning { get; set; }
			bool morphTargets { get; set; }
			bool morphNormals { get; set; }
		}
		public partial class MeshLambertMaterial : Material
		{
			public virtual Color color { get; set; }
			public virtual Color emissive { get; set; }
			public virtual double emissiveIntensity { get; set; }
			public virtual Union<Texture, object> emissiveMap { get; set; }
			public virtual Union<Texture, object> map { get; set; }
			public virtual Union<Texture, object> lightMap { get; set; }
			public virtual double lightMapIntensity { get; set; }
			public virtual Union<Texture, object> aoMap { get; set; }
			public virtual double aoMapIntensity { get; set; }
			public virtual Union<Texture, object> specularMap { get; set; }
			public virtual Union<Texture, object> alphaMap { get; set; }
			public virtual Union<Texture, object> envMap { get; set; }
			public virtual Combine combine { get; set; }
			public virtual double reflectivity { get; set; }
			public virtual double refractionRatio { get; set; }
			public virtual bool wireframe { get; set; }
			public virtual double wireframeLinewidth { get; set; }
			public virtual string wireframeLinecap { get; set; }
			public virtual string wireframeLinejoin { get; set; }
			public virtual bool skinning { get; set; }
			public virtual bool morphTargets { get; set; }
			public virtual bool morphNormals { get; set; }
			public MeshLambertMaterial(MeshLambertMaterialParameters parameters) { }
			public virtual void setValues(MeshLambertMaterialParameters parameters) { }
			public MeshLambertMaterial() { }
		}
		public partial interface MeshStandardMaterialParameters : MaterialParameters
		{
			Union<Color, string, double> color { get; set; }
			double roughness { get; set; }
			double metalness { get; set; }
			Texture map { get; set; }
			Texture lightMap { get; set; }
			double lightMapIntensity { get; set; }
			Texture aoMap { get; set; }
			double aoMapIntensity { get; set; }
			Union<Color, string, double> emissive { get; set; }
			double emissiveIntensity { get; set; }
			Texture emissiveMap { get; set; }
			Texture bumpMap { get; set; }
			double bumpScale { get; set; }
			Texture normalMap { get; set; }
			Vector2 normalScale { get; set; }
			Texture displacementMap { get; set; }
			double displacementScale { get; set; }
			double displacementBias { get; set; }
			Texture roughnessMap { get; set; }
			Texture metalnessMap { get; set; }
			Texture alphaMap { get; set; }
			Texture envMap { get; set; }
			double envMapIntensity { get; set; }
			double refractionRatio { get; set; }
			bool wireframe { get; set; }
			double wireframeLinewidth { get; set; }
			bool skinning { get; set; }
			bool morphTargets { get; set; }
			bool morphNormals { get; set; }
		}
		public partial class MeshStandardMaterial : Material
		{
			public virtual object defines { get; set; }
			public virtual Color color { get; set; }
			public virtual double roughness { get; set; }
			public virtual double metalness { get; set; }
			public virtual Union<Texture, object> map { get; set; }
			public virtual Union<Texture, object> lightMap { get; set; }
			public virtual double lightMapIntensity { get; set; }
			public virtual Union<Texture, object> aoMap { get; set; }
			public virtual double aoMapIntensity { get; set; }
			public virtual Color emissive { get; set; }
			public virtual double emissiveIntensity { get; set; }
			public virtual Union<Texture, object> emissiveMap { get; set; }
			public virtual Union<Texture, object> bumpMap { get; set; }
			public virtual double bumpScale { get; set; }
			public virtual Union<Texture, object> normalMap { get; set; }
			public virtual double normalScale { get; set; }
			public virtual Union<Texture, object> displacementMap { get; set; }
			public virtual double displacementScale { get; set; }
			public virtual double displacementBias { get; set; }
			public virtual Union<Texture, object> roughnessMap { get; set; }
			public virtual Union<Texture, object> metalnessMap { get; set; }
			public virtual Union<Texture, object> alphaMap { get; set; }
			public virtual Union<Texture, object> envMap { get; set; }
			public virtual double envMapIntensity { get; set; }
			public virtual double refractionRatio { get; set; }
			public virtual bool wireframe { get; set; }
			public virtual double wireframeLinewidth { get; set; }
			public virtual bool skinning { get; set; }
			public virtual bool morphTargets { get; set; }
			public virtual bool morphNormals { get; set; }
			public MeshStandardMaterial(MeshStandardMaterialParameters parameters) { }
			public virtual void setValues(MeshStandardMaterialParameters parameters) { }
			public MeshStandardMaterial() { }
		}
		public partial interface MeshNormalMaterialParameters : MaterialParameters
		{
			bool wireframe { get; set; }
			double wireframeLinewidth { get; set; }
			bool morphTargets { get; set; }
		}
		public partial class MeshNormalMaterial : Material
		{
			public virtual bool wireframe { get; set; }
			public virtual double wireframeLinewidth { get; set; }
			public virtual bool morphTargets { get; set; }
			public MeshNormalMaterial(MeshNormalMaterialParameters parameters) { }
			public virtual void setValues(MeshNormalMaterialParameters parameters) { }
			public MeshNormalMaterial() { }
		}
		public partial interface MeshPhongMaterialParameters : MaterialParameters
		{
			Union<Color, string, double> color { get; set; }
			Union<Color, string, double> specular { get; set; }
			double shininess { get; set; }
			double opacity { get; set; }
			Texture map { get; set; }
			Texture lightMap { get; set; }
			double lightMapIntensity { get; set; }
			Texture aoMap { get; set; }
			double aoMapIntensity { get; set; }
			Union<Color, string, double> emissive { get; set; }
			double emissiveIntensity { get; set; }
			Texture emissiveMap { get; set; }
			Texture bumpMap { get; set; }
			double bumpScale { get; set; }
			Texture normalMap { get; set; }
			Vector2 normalScale { get; set; }
			Texture displacementMap { get; set; }
			double displacementScale { get; set; }
			double displacementBias { get; set; }
			Texture specularMap { get; set; }
			Texture alphaMap { get; set; }
			Texture envMap { get; set; }
			Combine combine { get; set; }
			double reflectivity { get; set; }
			double refractionRatio { get; set; }
			bool wireframe { get; set; }
			double wireframeLinewidth { get; set; }
			string wireframeLinecap { get; set; }
			string wireframeLinejoin { get; set; }
			bool skinning { get; set; }
			bool morphTargets { get; set; }
			bool morphNormals { get; set; }
		}
		public partial class MeshPhongMaterial : Material
		{
			public virtual Color color { get; set; }
			public virtual Color specular { get; set; }
			public virtual double shininess { get; set; }
			public virtual Union<Texture, object> map { get; set; }
			public virtual Union<Texture, object> lightMap { get; set; }
			public virtual double lightMapIntensity { get; set; }
			public virtual Union<Texture, object> aoMap { get; set; }
			public virtual double aoMapIntensity { get; set; }
			public virtual Color emissive { get; set; }
			public virtual double emissiveIntensity { get; set; }
			public virtual Union<Texture, object> emissiveMap { get; set; }
			public virtual Union<Texture, object> bumpMap { get; set; }
			public virtual double bumpScale { get; set; }
			public virtual Union<Texture, object> normalMap { get; set; }
			public virtual Vector2 normalScale { get; set; }
			public virtual Union<Texture, object> displacementMap { get; set; }
			public virtual double displacementScale { get; set; }
			public virtual double displacementBias { get; set; }
			public virtual Union<Texture, object> specularMap { get; set; }
			public virtual Union<Texture, object> alphaMap { get; set; }
			public virtual Union<Texture, object> envMap { get; set; }
			public virtual Combine combine { get; set; }
			public virtual double reflectivity { get; set; }
			public virtual double refractionRatio { get; set; }
			public virtual bool wireframe { get; set; }
			public virtual double wireframeLinewidth { get; set; }
			public virtual string wireframeLinecap { get; set; }
			public virtual string wireframeLinejoin { get; set; }
			public virtual bool skinning { get; set; }
			public virtual bool morphTargets { get; set; }
			public virtual bool morphNormals { get; set; }
			public virtual bool metal { get; set; }
			public MeshPhongMaterial(MeshPhongMaterialParameters parameters) { }
			public virtual void setValues(MeshPhongMaterialParameters parameters) { }
			public MeshPhongMaterial() { }
		}
		public partial interface MeshPhysicalMaterialParameters : MeshStandardMaterialParameters
		{
			double reflectivity { get; set; }
			double clearCoat { get; set; }
			double clearCoatRoughness { get; set; }
		}
		public partial class MeshPhysicalMaterial : MeshStandardMaterial
		{
			public virtual object defines { get; set; }
			public virtual double reflectivity { get; set; }
			public virtual double clearCoat { get; set; }
			public virtual double clearCoatRoughness { get; set; }
			public MeshPhysicalMaterial(MeshPhysicalMaterialParameters parameters) { }
			public MeshPhysicalMaterial() { }
		}
		public partial class MultiMaterial : Material
		{
			public virtual bool isMultiMaterial { get; set; }
			public virtual Material[] materials { get; set; }
			public MultiMaterial(Material[] materials) { }
			public virtual object toJSON(object meta) => default(object);
			public MultiMaterial() { }
		}
		public partial class MeshFaceMaterial : MultiMaterial
		{
			public MeshFaceMaterial() { }
		}
		public partial interface PointsMaterialParameters : MaterialParameters
		{
			Union<Color, string, double> color { get; set; }
			Texture map { get; set; }
			double size { get; set; }
			bool sizeAttenuation { get; set; }
		}
		public partial class PointsMaterial : Material
		{
			public virtual Color color { get; set; }
			public virtual Union<Texture, object> map { get; set; }
			public virtual double size { get; set; }
			public virtual bool sizeAttenuation { get; set; }
			public PointsMaterial(PointsMaterialParameters parameters) { }
			public virtual void setValues(PointsMaterialParameters parameters) { }
			public PointsMaterial() { }
		}
		public partial class PointCloudMaterial : PointsMaterial
		{
			public PointCloudMaterial() { }
		}
		public partial class ParticleBasicMaterial : PointsMaterial
		{
			public ParticleBasicMaterial() { }
		}
		public partial class ParticleSystemMaterial : PointsMaterial
		{
			public ParticleSystemMaterial() { }
		}
		public partial interface ShaderMaterialParameters : MaterialParameters
		{
			object defines { get; set; }
			object uniforms { get; set; }
			string vertexShader { get; set; }
			string fragmentShader { get; set; }
			double linewidth { get; set; }
			bool wireframe { get; set; }
			double wireframeLinewidth { get; set; }
			bool lights { get; set; }
			bool clipping { get; set; }
			bool skinning { get; set; }
			bool morphTargets { get; set; }
			bool morphNormals { get; set; }
		}
		public partial class ShaderMaterial : Material
		{
			public partial interface ShaderMaterial_Type_0
			{
				IUniform this[string uniform] { get; set; }
			}
			public partial interface ShaderMaterial_Type_1
			{
				bool derivatives { get; set; }
				bool fragDepth { get; set; }
				bool drawBuffers { get; set; }
				bool shaderTextureLOD { get; set; }
			}
			public virtual object defines { get; set; }
			public virtual ShaderMaterial_Type_0 uniforms { get; set; }
			public virtual string vertexShader { get; set; }
			public virtual string fragmentShader { get; set; }
			public virtual double linewidth { get; set; }
			public virtual bool wireframe { get; set; }
			public virtual double wireframeLinewidth { get; set; }
			public virtual bool lights { get; set; }
			public virtual bool clipping { get; set; }
			public virtual bool skinning { get; set; }
			public virtual bool morphTargets { get; set; }
			public virtual bool morphNormals { get; set; }
			public virtual object derivatives { get; set; }
			public virtual ShaderMaterial_Type_1 extensions { get; set; }
			public virtual object defaultAttributeValues { get; set; }
			public virtual Union<string, undefined> index0AttributeName { get; set; }
			public ShaderMaterial(ShaderMaterialParameters parameters) { }
			public virtual void setValues(ShaderMaterialParameters parameters) { }
			public virtual object toJSON(object meta) => default(object);
			public ShaderMaterial() { }
		}
		public partial class RawShaderMaterial : ShaderMaterial
		{
			public RawShaderMaterial(ShaderMaterialParameters parameters) { }
			public RawShaderMaterial() { }
		}
		public partial interface SpriteMaterialParameters : MaterialParameters
		{
			Union<Color, string, double> color { get; set; }
			Texture map { get; set; }
			double rotation { get; set; }
		}
		public partial class SpriteMaterial : Material
		{
			public virtual Color color { get; set; }
			public virtual Union<Texture, object> map { get; set; }
			public virtual double rotation { get; set; }
			public virtual bool isSpriteMaterial { get; set; }
			public SpriteMaterial(SpriteMaterialParameters parameters) { }
			public virtual void setValues(SpriteMaterialParameters parameters) { }
			public virtual SpriteMaterial copy(SpriteMaterial source) => default(SpriteMaterial);
			public SpriteMaterial() { }
		}
		public partial class ShadowMaterial : ShaderMaterial
		{
			public ShadowMaterial(ShaderMaterialParameters parameters) { }
			public ShadowMaterial() { }
		}
		public partial class Box2
		{
			public virtual Vector2 max { get; set; }
			public virtual Vector2 min { get; set; }
			public Box2(Vector2 min, Vector2 max) { }
			public virtual Box2 set(Vector2 min, Vector2 max) => default(Box2);
			public virtual Box2 setFromPoints(Vector2[] points) => default(Box2);
			public virtual Box2 setFromCenterAndSize(Vector2 center, Vector2 size) => default(Box2);
			public virtual Box2 clone() => default(Box2);
			public virtual Box2 copy(Box2 box) => default(Box2);
			public virtual Box2 makeEmpty() => default(Box2);
			public virtual bool isEmpty() => default(bool);
			public virtual Vector2 getCenter(Vector2 target) => default(Vector2);
			public virtual Vector2 getSize(Vector2 target) => default(Vector2);
			public virtual Box2 expandByPoint(Vector2 point) => default(Box2);
			public virtual Box2 expandByVector(Vector2 vector) => default(Box2);
			public virtual Box2 expandByScalar(double scalar) => default(Box2);
			public virtual bool containsPoint(Vector2 point) => default(bool);
			public virtual bool containsBox(Box2 box) => default(bool);
			public virtual Vector2 getParameter(Vector2 point) => default(Vector2);
			public virtual bool intersectsBox(Box2 box) => default(bool);
			public virtual Vector2 clampPoint(Vector2 point, Vector2 target) => default(Vector2);
			public virtual double distanceToPoint(Vector2 point) => default(double);
			public virtual Box2 intersect(Box2 box) => default(Box2);
			public virtual Box2 union(Box2 box) => default(Box2);
			public virtual Box2 translate(Vector2 offset) => default(Box2);
			public virtual bool equals(Box2 box) => default(bool);
			public virtual object empty() => default(object);
			public virtual object isIntersectionBox(object b) => default(object);
			public Box2() { }
		}
		public partial class Box3
		{
			public virtual Vector3 max { get; set; }
			public virtual Vector3 min { get; set; }
			public Box3(Vector3 min, Vector3 max) { }
			public virtual Box3 set(Vector3 min, Vector3 max) => default(Box3);
			public virtual Box3 setFromArray(ArrayLike<double> array) => default(Box3);
			public virtual Box3 setFromPoints(Vector3[] points) => default(Box3);
			public virtual Box3 setFromCenterAndSize(Vector3 center, Vector3 size) => default(Box3);
			public virtual Box3 setFromObject(Object3D @object) => default(Box3);
			public virtual Box3 clone() => default(Box3);
			public virtual Box3 copy(Box3 box) => default(Box3);
			public virtual Box3 makeEmpty() => default(Box3);
			public virtual bool isEmpty() => default(bool);
			public virtual Vector3 getCenter(Vector3 target) => default(Vector3);
			public virtual Vector3 getSize(Vector3 target) => default(Vector3);
			public virtual Box3 expandByPoint(Vector3 point) => default(Box3);
			public virtual Box3 expandByVector(Vector3 vector) => default(Box3);
			public virtual Box3 expandByScalar(double scalar) => default(Box3);
			public virtual Box3 expandByObject(Object3D @object) => default(Box3);
			public virtual bool containsPoint(Vector3 point) => default(bool);
			public virtual bool containsBox(Box3 box) => default(bool);
			public virtual Vector3 getParameter(Vector3 point) => default(Vector3);
			public virtual bool intersectsBox(Box3 box) => default(bool);
			public virtual bool intersectsSphere(Sphere sphere) => default(bool);
			public virtual bool intersectsPlane(Plane plane) => default(bool);
			public virtual Vector3 clampPoint(Vector3 point, Vector3 target) => default(Vector3);
			public virtual double distanceToPoint(Vector3 point) => default(double);
			public virtual Sphere getBoundingSphere(Sphere target) => default(Sphere);
			public virtual Box3 intersect(Box3 box) => default(Box3);
			public virtual Box3 union(Box3 box) => default(Box3);
			public virtual Box3 applyMatrix4(Matrix4 matrix) => default(Box3);
			public virtual Box3 translate(Vector3 offset) => default(Box3);
			public virtual bool equals(Box3 box) => default(bool);
			public virtual object empty() => default(object);
			public virtual object isIntersectionBox(object b) => default(object);
			public virtual object isIntersectionSphere(object s) => default(object);
			public Box3() { }
		}
		public partial interface HSL
		{
			double h { get; set; }
			double s { get; set; }
			double l { get; set; }
		}
		public partial class Color
		{
			public virtual double r { get; set; }
			public virtual double g { get; set; }
			public virtual double b { get; set; }
			public Color(Union<Color, string, double> color) { }
			public Color(double r, double g, double b) { }
			public virtual Color set(Color color) => default(Color);
			public virtual Color set(double color) => default(Color);
			public virtual Color set(string color) => default(Color);
			public virtual Color setScalar(double scalar) => default(Color);
			public virtual Color setHex(double hex) => default(Color);
			public virtual Color setRGB(double r, double g, double b) => default(Color);
			public virtual Color setHSL(double h, double s, double l) => default(Color);
			public virtual Color setStyle(string style) => default(Color);
			public virtual Color clone() => default(Color);
			public virtual Color copy(Color color) => default(Color);
			public virtual Color copyGammaToLinear(Color color, double gammaFactor) => default(Color);
			public virtual Color copyLinearToGamma(Color color, double gammaFactor) => default(Color);
			public virtual Color convertGammaToLinear() => default(Color);
			public virtual Color convertLinearToGamma() => default(Color);
			public virtual double getHex() => default(double);
			public virtual string getHexString() => default(string);
			public virtual HSL getHSL(HSL target) => default(HSL);
			public virtual string getStyle() => default(string);
			public virtual Color offsetHSL(double h, double s, double l) => default(Color);
			public virtual Color add(Color color) => default(Color);
			public virtual Color addColors(Color color1, Color color2) => default(Color);
			public virtual Color addScalar(double s) => default(Color);
			public virtual Color sub(Color color) => default(Color);
			public virtual Color multiply(Color color) => default(Color);
			public virtual Color multiplyScalar(double s) => default(Color);
			public virtual Color lerp(Color color, double alpha) => default(Color);
			public virtual Color lerpHSL(Color color, double alpha) => default(Color);
			public virtual bool equals(Color color) => default(bool);
			public virtual Color fromArray(double[] rgb, double offset) => default(Color);
			public virtual double[] toArray(double[] array, double offset) => default(double[]);
			public virtual ArrayLike<double> toArray(ArrayLike<double> xyz, double offset) => default(ArrayLike<double>);
			public Color() { }
		}
		public partial class ColorKeywords
		{
			public virtual double aliceblue { get; set; }
			public virtual double antiquewhite { get; set; }
			public virtual double aqua { get; set; }
			public virtual double aquamarine { get; set; }
			public virtual double azure { get; set; }
			public virtual double beige { get; set; }
			public virtual double bisque { get; set; }
			public virtual double black { get; set; }
			public virtual double blanchedalmond { get; set; }
			public virtual double blue { get; set; }
			public virtual double blueviolet { get; set; }
			public virtual double brown { get; set; }
			public virtual double burlywood { get; set; }
			public virtual double cadetblue { get; set; }
			public virtual double chartreuse { get; set; }
			public virtual double chocolate { get; set; }
			public virtual double coral { get; set; }
			public virtual double cornflowerblue { get; set; }
			public virtual double cornsilk { get; set; }
			public virtual double crimson { get; set; }
			public virtual double cyan { get; set; }
			public virtual double darkblue { get; set; }
			public virtual double darkcyan { get; set; }
			public virtual double darkgoldenrod { get; set; }
			public virtual double darkgray { get; set; }
			public virtual double darkgreen { get; set; }
			public virtual double darkgrey { get; set; }
			public virtual double darkkhaki { get; set; }
			public virtual double darkmagenta { get; set; }
			public virtual double darkolivegreen { get; set; }
			public virtual double darkorange { get; set; }
			public virtual double darkorchid { get; set; }
			public virtual double darkred { get; set; }
			public virtual double darksalmon { get; set; }
			public virtual double darkseagreen { get; set; }
			public virtual double darkslateblue { get; set; }
			public virtual double darkslategray { get; set; }
			public virtual double darkslategrey { get; set; }
			public virtual double darkturquoise { get; set; }
			public virtual double darkviolet { get; set; }
			public virtual double deeppink { get; set; }
			public virtual double deepskyblue { get; set; }
			public virtual double dimgray { get; set; }
			public virtual double dimgrey { get; set; }
			public virtual double dodgerblue { get; set; }
			public virtual double firebrick { get; set; }
			public virtual double floralwhite { get; set; }
			public virtual double forestgreen { get; set; }
			public virtual double fuchsia { get; set; }
			public virtual double gainsboro { get; set; }
			public virtual double ghostwhite { get; set; }
			public virtual double gold { get; set; }
			public virtual double goldenrod { get; set; }
			public virtual double gray { get; set; }
			public virtual double green { get; set; }
			public virtual double greenyellow { get; set; }
			public virtual double grey { get; set; }
			public virtual double honeydew { get; set; }
			public virtual double hotpink { get; set; }
			public virtual double indianred { get; set; }
			public virtual double indigo { get; set; }
			public virtual double ivory { get; set; }
			public virtual double khaki { get; set; }
			public virtual double lavender { get; set; }
			public virtual double lavenderblush { get; set; }
			public virtual double lawngreen { get; set; }
			public virtual double lemonchiffon { get; set; }
			public virtual double lightblue { get; set; }
			public virtual double lightcoral { get; set; }
			public virtual double lightcyan { get; set; }
			public virtual double lightgoldenrodyellow { get; set; }
			public virtual double lightgray { get; set; }
			public virtual double lightgreen { get; set; }
			public virtual double lightgrey { get; set; }
			public virtual double lightpink { get; set; }
			public virtual double lightsalmon { get; set; }
			public virtual double lightseagreen { get; set; }
			public virtual double lightskyblue { get; set; }
			public virtual double lightslategray { get; set; }
			public virtual double lightslategrey { get; set; }
			public virtual double lightsteelblue { get; set; }
			public virtual double lightyellow { get; set; }
			public virtual double lime { get; set; }
			public virtual double limegreen { get; set; }
			public virtual double linen { get; set; }
			public virtual double magenta { get; set; }
			public virtual double maroon { get; set; }
			public virtual double mediumaquamarine { get; set; }
			public virtual double mediumblue { get; set; }
			public virtual double mediumorchid { get; set; }
			public virtual double mediumpurple { get; set; }
			public virtual double mediumseagreen { get; set; }
			public virtual double mediumslateblue { get; set; }
			public virtual double mediumspringgreen { get; set; }
			public virtual double mediumturquoise { get; set; }
			public virtual double mediumvioletred { get; set; }
			public virtual double midnightblue { get; set; }
			public virtual double mintcream { get; set; }
			public virtual double mistyrose { get; set; }
			public virtual double moccasin { get; set; }
			public virtual double navajowhite { get; set; }
			public virtual double navy { get; set; }
			public virtual double oldlace { get; set; }
			public virtual double olive { get; set; }
			public virtual double olivedrab { get; set; }
			public virtual double orange { get; set; }
			public virtual double orangered { get; set; }
			public virtual double orchid { get; set; }
			public virtual double palegoldenrod { get; set; }
			public virtual double palegreen { get; set; }
			public virtual double paleturquoise { get; set; }
			public virtual double palevioletred { get; set; }
			public virtual double papayawhip { get; set; }
			public virtual double peachpuff { get; set; }
			public virtual double peru { get; set; }
			public virtual double pink { get; set; }
			public virtual double plum { get; set; }
			public virtual double powderblue { get; set; }
			public virtual double purple { get; set; }
			public virtual double red { get; set; }
			public virtual double rosybrown { get; set; }
			public virtual double royalblue { get; set; }
			public virtual double saddlebrown { get; set; }
			public virtual double salmon { get; set; }
			public virtual double sandybrown { get; set; }
			public virtual double seagreen { get; set; }
			public virtual double seashell { get; set; }
			public virtual double sienna { get; set; }
			public virtual double silver { get; set; }
			public virtual double skyblue { get; set; }
			public virtual double slateblue { get; set; }
			public virtual double slategray { get; set; }
			public virtual double slategrey { get; set; }
			public virtual double snow { get; set; }
			public virtual double springgreen { get; set; }
			public virtual double steelblue { get; set; }
			public virtual double tan { get; set; }
			public virtual double teal { get; set; }
			public virtual double thistle { get; set; }
			public virtual double tomato { get; set; }
			public virtual double turquoise { get; set; }
			public virtual double violet { get; set; }
			public virtual double wheat { get; set; }
			public virtual double white { get; set; }
			public virtual double whitesmoke { get; set; }
			public virtual double yellow { get; set; }
			public virtual double yellowgreen { get; set; }
			public ColorKeywords() { }
		}
		public partial class Euler
		{
			public virtual double x { get; set; }
			public virtual double y { get; set; }
			public virtual double z { get; set; }
			public virtual string order { get; set; }
			public virtual Function onChangeCallback { get; set; }
			public virtual string[] RotationOrders { get; set; }
			public virtual string DefaultOrder { get; set; }
			public Euler(double x, double y, double z, string order) { }
			public virtual Euler set(double x, double y, double z, string order) => default(Euler);
			public virtual Euler clone() => default(Euler);
			public virtual Euler copy(Euler euler) => default(Euler);
			public virtual Euler setFromRotationMatrix(Matrix4 m, string order, bool update) => default(Euler);
			public virtual Euler setFromQuaternion(Quaternion q, string order, bool update) => default(Euler);
			public virtual Euler setFromVector3(Vector3 v, string order) => default(Euler);
			public virtual Euler reorder(string newOrder) => default(Euler);
			public virtual bool equals(Euler euler) => default(bool);
			public virtual Euler fromArray(object[] xyzo) => default(Euler);
			public virtual double[] toArray(double[] array, double offset) => default(double[]);
			public virtual Vector3 toVector3(Vector3 optionalResult) => default(Vector3);
			public virtual Euler onChange(Function callback) => default(Euler);
			public Euler() { }
		}
		public partial class Frustum
		{
			public virtual Plane[] planes { get; set; }
			public Frustum(Plane p0, Plane p1, Plane p2, Plane p3, Plane p4, Plane p5) { }
			public virtual Frustum set(double p0, double p1, double p2, double p3, double p4, double p5) => default(Frustum);
			public virtual Frustum clone() => default(Frustum);
			public virtual Frustum copy(Frustum frustum) => default(Frustum);
			public virtual Frustum setFromMatrix(Matrix4 m) => default(Frustum);
			public virtual bool intersectsObject(Object3D @object) => default(bool);
			public virtual bool intersectsObject(Sprite sprite) => default(bool);
			public virtual bool intersectsSphere(Sphere sphere) => default(bool);
			public virtual bool intersectsBox(Box3 box) => default(bool);
			public virtual bool containsPoint(Vector3 point) => default(bool);
			public Frustum() { }
		}
		public partial class Line3
		{
			public virtual Vector3 start { get; set; }
			public virtual Vector3 end { get; set; }
			public Line3(Vector3 start, Vector3 end) { }
			public virtual Line3 set(Vector3 start, Vector3 end) => default(Line3);
			public virtual Line3 clone() => default(Line3);
			public virtual Line3 copy(Line3 line) => default(Line3);
			public virtual Vector3 getCenter(Vector3 target) => default(Vector3);
			public virtual Vector3 delta(Vector3 target) => default(Vector3);
			public virtual double distanceSq() => default(double);
			public virtual double distance() => default(double);
			public virtual Vector3 at(double t, Vector3 target) => default(Vector3);
			public virtual double closestPointToPointParameter(Vector3 point, bool clampToLine) => default(double);
			public virtual Vector3 closestPointToPoint(Vector3 point, bool clampToLine, Vector3 target) => default(Vector3);
			public virtual Line3 applyMatrix4(Matrix4 matrix) => default(Line3);
			public virtual bool equals(Line3 line) => default(bool);
			public Line3() { }
		}
		public partial class Math
		{
			public virtual double DEG2RAD { get; set; }
			public virtual double RAD2DEG { get; set; }
			public virtual string generateUUID() => default(string);
			public virtual double clamp(double value, double min, double max) => default(double);
			public virtual double euclideanModulo(double n, double m) => default(double);
			public virtual double mapLinear(double x, double a1, double a2, double b1, double b2) => default(double);
			public virtual double smoothstep(double x, double min, double max) => default(double);
			public virtual double smootherstep(double x, double min, double max) => default(double);
			public virtual double random16() => default(double);
			public virtual double randInt(double low, double high) => default(double);
			public virtual double randFloat(double low, double high) => default(double);
			public virtual double randFloatSpread(double range) => default(double);
			public virtual double degToRad(double degrees) => default(double);
			public virtual double radToDeg(double radians) => default(double);
			public virtual bool isPowerOfTwo(double value) => default(bool);
			public virtual double lerp(double x, double y, double t) => default(double);
			public virtual double nearestPowerOfTwo(double value) => default(double);
			public virtual double nextPowerOfTwo(double value) => default(double);
			public virtual double floorPowerOfTwo(double value) => default(double);
			public virtual double ceilPowerOfTwo(double value) => default(double);
			public Math() { }
		}
		public partial interface Matrix
		{
			Float32Array elements { get; set; }
			Matrix identity();
			Matrix copy(Matrix m);
			Matrix multiplyScalar(double s);
			double determinant();
			Matrix getInverse(Matrix matrix, bool throwOnInvertible);
			Matrix transpose();
			Matrix clone();
		}
		public partial class Matrix3 : Matrix
		{
			public virtual Float32Array elements { get; set; }
			public Matrix3() { }
			public virtual Matrix3 set(double n11, double n12, double n13, double n21, double n22, double n23, double n31, double n32, double n33) => default(Matrix3);
			public virtual Matrix3 identity() => default(Matrix3);
			public virtual Matrix3 clone() => default(Matrix3);
			public virtual Matrix3 copy(Matrix3 m) => default(Matrix3);
			public virtual Matrix3 setFromMatrix4(Matrix4 m) => default(Matrix3);
			public virtual BufferAttribute applyToBuffer(BufferAttribute buffer, double offset, double length) => default(BufferAttribute);
			public virtual BufferAttribute applyToBufferAttribute(BufferAttribute attribute) => default(BufferAttribute);
			public virtual Matrix3 multiplyScalar(double s) => default(Matrix3);
			public virtual double determinant() => default(double);
			public virtual Matrix3 getInverse(Matrix3 matrix, bool throwOnDegenerate) => default(Matrix3);
			public virtual Matrix3 transpose() => default(Matrix3);
			public virtual Matrix3 getNormalMatrix(Matrix4 matrix4) => default(Matrix3);
			public virtual double[] transposeIntoArray(double[] r) => default(double[]);
			public virtual Matrix3 fromArray(double[] array, double offset) => default(Matrix3);
			public virtual double[] toArray() => default(double[]);
			public virtual Matrix3 multiply(Matrix3 m) => default(Matrix3);
			public virtual Matrix3 premultiply(Matrix3 m) => default(Matrix3);
			public virtual Matrix3 multiplyMatrices(Matrix3 a, Matrix3 b) => default(Matrix3);
			public virtual object multiplyVector3(Vector3 vector) => default(object);
			public virtual object multiplyVector3Array(object a) => default(object);
			public virtual Matrix3 getInverse(Matrix4 matrix, bool throwOnDegenerate) => default(Matrix3);
			public virtual double[] flattenToArrayOffset(double[] array, double offset) => default(double[]);
			Matrix THREE.Matrix.identity() => default(Matrix);
			Matrix THREE.Matrix.copy(Matrix m) => default(Matrix);
			Matrix THREE.Matrix.multiplyScalar(double s) => default(Matrix);
			double THREE.Matrix.determinant() => default(double);
			Matrix THREE.Matrix.getInverse(Matrix matrix, bool throwOnInvertible) => default(Matrix);
			Matrix THREE.Matrix.transpose() => default(Matrix);
			Matrix THREE.Matrix.clone() => default(Matrix);
		}
		public partial class Matrix4 : Matrix
		{
			public virtual Float32Array elements { get; set; }
			public Matrix4() { }
			public virtual Matrix4 set(double n11, double n12, double n13, double n14, double n21, double n22, double n23, double n24, double n31, double n32, double n33, double n34, double n41, double n42, double n43, double n44) => default(Matrix4);
			public virtual Matrix4 identity() => default(Matrix4);
			public virtual Matrix4 clone() => default(Matrix4);
			public virtual Matrix4 copy(Matrix4 m) => default(Matrix4);
			public virtual Matrix4 copyPosition(Matrix4 m) => default(Matrix4);
			public virtual Matrix4 extractBasis(Vector3 xAxis, Vector3 yAxis, Vector3 zAxis) => default(Matrix4);
			public virtual Matrix4 makeBasis(Vector3 xAxis, Vector3 yAxis, Vector3 zAxis) => default(Matrix4);
			public virtual Matrix4 extractRotation(Matrix4 m) => default(Matrix4);
			public virtual Matrix4 makeRotationFromEuler(Euler euler) => default(Matrix4);
			public virtual Matrix4 makeRotationFromQuaternion(Quaternion q) => default(Matrix4);
			public virtual Matrix4 lookAt(Vector3 eye, Vector3 target, Vector3 up) => default(Matrix4);
			public virtual Matrix4 multiply(Matrix4 m) => default(Matrix4);
			public virtual Matrix4 premultiply(Matrix4 m) => default(Matrix4);
			public virtual Matrix4 multiplyMatrices(Matrix4 a, Matrix4 b) => default(Matrix4);
			public virtual Matrix4 multiplyToArray(Matrix4 a, Matrix4 b, double[] r) => default(Matrix4);
			public virtual Matrix4 multiplyScalar(double s) => default(Matrix4);
			public virtual BufferAttribute applyToBuffer(BufferAttribute buffer, double offset, double length) => default(BufferAttribute);
			public virtual BufferAttribute applyToBufferAttribute(BufferAttribute attribute) => default(BufferAttribute);
			public virtual double determinant() => default(double);
			public virtual Matrix4 transpose() => default(Matrix4);
			public virtual Matrix4 setPosition(Vector3 v) => default(Matrix4);
			public virtual Matrix4 getInverse(Matrix4 m, bool throwOnDegeneratee) => default(Matrix4);
			public virtual Matrix4 scale(Vector3 v) => default(Matrix4);
			public virtual double getMaxScaleOnAxis() => default(double);
			public virtual Matrix4 makeTranslation(double x, double y, double z) => default(Matrix4);
			public virtual Matrix4 makeRotationX(double theta) => default(Matrix4);
			public virtual Matrix4 makeRotationY(double theta) => default(Matrix4);
			public virtual Matrix4 makeRotationZ(double theta) => default(Matrix4);
			public virtual Matrix4 makeRotationAxis(Vector3 axis, double angle) => default(Matrix4);
			public virtual Matrix4 makeScale(double x, double y, double z) => default(Matrix4);
			public virtual Matrix4 compose(Vector3 translation, Quaternion rotation, Vector3 scale) => default(Matrix4);
			public virtual Object[] decompose(Vector3 translation, Quaternion rotation, Vector3 scale) => default(Object[]);
			public virtual Matrix4 makePerspective(double left, double right, double bottom, double top, double near, double far) => default(Matrix4);
			public virtual Matrix4 makePerspective(double fov, double aspect, double near, double far) => default(Matrix4);
			public virtual Matrix4 makeOrthographic(double left, double right, double top, double bottom, double near, double far) => default(Matrix4);
			public virtual bool equals(Matrix4 matrix) => default(bool);
			public virtual Matrix4 fromArray(double[] array, double offset) => default(Matrix4);
			public virtual double[] toArray() => default(double[]);
			public virtual Matrix4 extractPosition(Matrix4 m) => default(Matrix4);
			public virtual Matrix4 setRotationFromQuaternion(Quaternion q) => default(Matrix4);
			public virtual object multiplyVector3(object v) => default(object);
			public virtual object multiplyVector4(object v) => default(object);
			public virtual double[] multiplyVector3Array(double[] array) => default(double[]);
			public virtual void rotateAxis(object v) { }
			public virtual void crossVector(object v) { }
			public virtual double[] flattenToArrayOffset(double[] array, double offset) => default(double[]);
			Matrix THREE.Matrix.identity() => default(Matrix);
			Matrix THREE.Matrix.copy(Matrix m) => default(Matrix);
			Matrix THREE.Matrix.multiplyScalar(double s) => default(Matrix);
			double THREE.Matrix.determinant() => default(double);
			Matrix THREE.Matrix.getInverse(Matrix matrix, bool throwOnInvertible) => default(Matrix);
			Matrix THREE.Matrix.transpose() => default(Matrix);
			Matrix THREE.Matrix.clone() => default(Matrix);
		}
		public partial class Plane
		{
			public virtual Vector3 normal { get; set; }
			public virtual double constant { get; set; }
			public Plane(Vector3 normal, double constant) { }
			public virtual Plane set(Vector3 normal, double constant) => default(Plane);
			public virtual Plane setComponents(double x, double y, double z, double w) => default(Plane);
			public virtual Plane setFromNormalAndCoplanarPoint(Vector3 normal, Vector3 point) => default(Plane);
			public virtual Plane setFromCoplanarPoints(Vector3 a, Vector3 b, Vector3 c) => default(Plane);
			public virtual Plane clone() => default(Plane);
			public virtual Plane copy(Plane plane) => default(Plane);
			public virtual Plane normalize() => default(Plane);
			public virtual Plane negate() => default(Plane);
			public virtual double distanceToPoint(Vector3 point) => default(double);
			public virtual double distanceToSphere(Sphere sphere) => default(double);
			public virtual Vector3 projectPoint(Vector3 point, Vector3 target) => default(Vector3);
			public virtual Vector3 orthoPoint(Vector3 point, Vector3 target) => default(Vector3);
			public virtual Vector3 intersectLine(Line3 line, Vector3 target) => default(Vector3);
			public virtual bool intersectsLine(Line3 line) => default(bool);
			public virtual bool intersectsBox(Box3 box) => default(bool);
			public virtual Vector3 coplanarPoint(Vector3 target) => default(Vector3);
			public virtual Plane applyMatrix4(Matrix4 matrix, Matrix3 optionalNormalMatrix) => default(Plane);
			public virtual Plane translate(Vector3 offset) => default(Plane);
			public virtual bool equals(Plane plane) => default(bool);
			public virtual object isIntersectionLine(object l) => default(object);
			public Plane() { }
		}
		public partial class Spherical
		{
			public virtual double radius { get; set; }
			public virtual double phi { get; set; }
			public virtual double theta { get; set; }
			public Spherical(double radius, double phi, double theta) { }
			public virtual Spherical set(double radius, double phi, double theta) => default(Spherical);
			public virtual Spherical clone() => default(Spherical);
			public virtual Spherical copy(Spherical other) => default(Spherical);
			public virtual void makeSafe() { }
			public virtual Spherical setFromVector3(Vector3 vec3) => default(Spherical);
			public Spherical() { }
		}
		public partial class Cylindrical
		{
			public virtual double radius { get; set; }
			public virtual double theta { get; set; }
			public virtual double y { get; set; }
			public Cylindrical(double radius, double theta, double y) { }
			public virtual Cylindrical clone() => default(Cylindrical);
			public virtual Cylindrical copy(Cylindrical other) => default(Cylindrical);
			public virtual Cylindrical set(double radius, double theta, double y) => default(Cylindrical);
			public virtual Cylindrical setFromVector3(Vector3 vec3) => default(Cylindrical);
			public Cylindrical() { }
		}
		public partial class Quaternion
		{
			public virtual double x { get; set; }
			public virtual double y { get; set; }
			public virtual double z { get; set; }
			public virtual double w { get; set; }
			public virtual Function onChangeCallback { get; set; }
			public Quaternion(double x, double y, double z, double w) { }
			public virtual Quaternion set(double x, double y, double z, double w) => default(Quaternion);
			public virtual Quaternion clone() => default(Quaternion);
			public virtual Quaternion copy(Quaternion q) => default(Quaternion);
			public virtual Quaternion setFromEuler(Euler euler, bool update) => default(Quaternion);
			public virtual Quaternion setFromAxisAngle(Vector3 axis, double angle) => default(Quaternion);
			public virtual Quaternion setFromRotationMatrix(Matrix4 m) => default(Quaternion);
			public virtual Quaternion setFromUnitVectors(Vector3 vFrom, Vector3 vTo) => default(Quaternion);
			public virtual Quaternion inverse() => default(Quaternion);
			public virtual Quaternion conjugate() => default(Quaternion);
			public virtual double dot(Quaternion v) => default(double);
			public virtual double lengthSq() => default(double);
			public virtual double length() => default(double);
			public virtual Quaternion normalize() => default(Quaternion);
			public virtual Quaternion multiply(Quaternion q) => default(Quaternion);
			public virtual Quaternion premultiply(Quaternion q) => default(Quaternion);
			public virtual Quaternion multiplyQuaternions(Quaternion a, Quaternion b) => default(Quaternion);
			public virtual Quaternion slerp(Quaternion qb, double t) => default(Quaternion);
			public virtual bool equals(Quaternion v) => default(bool);
			public virtual Quaternion fromArray(double[] n) => default(Quaternion);
			public virtual double[] toArray() => default(double[]);
			public virtual Quaternion fromArray(double[] xyzw, double offset) => default(Quaternion);
			public virtual Quaternion onChange(Function callback) => default(Quaternion);
			public virtual Quaternion slerp(Quaternion qa, Quaternion qb, Quaternion qm, double t) => default(Quaternion);
			public virtual Quaternion slerpFlat(double[] dst, double dstOffset, double[] src0, double srcOffset, double[] src1, double stcOffset1, double t) => default(Quaternion);
			public virtual object multiplyVector3(object v) => default(object);
			public Quaternion() { }
		}
		public partial class Ray
		{
			public virtual Vector3 origin { get; set; }
			public virtual Vector3 direction { get; set; }
			public Ray(Vector3 origin, Vector3 direction) { }
			public virtual Ray set(Vector3 origin, Vector3 direction) => default(Ray);
			public virtual Ray clone() => default(Ray);
			public virtual Ray copy(Ray ray) => default(Ray);
			public virtual Vector3 at(double t, Vector3 target) => default(Vector3);
			public virtual Vector3 lookAt(Vector3 v) => default(Vector3);
			public virtual Ray recast(double t) => default(Ray);
			public virtual Vector3 closestPointToPoint(Vector3 point, Vector3 target) => default(Vector3);
			public virtual double distanceToPoint(Vector3 point) => default(double);
			public virtual double distanceSqToPoint(Vector3 point) => default(double);
			public virtual double distanceSqToSegment(Vector3 v0, Vector3 v1, Vector3 optionalPointOnRay, Vector3 optionalPointOnSegment) => default(double);
			public virtual Vector3 intersectSphere(Sphere sphere, Vector3 target) => default(Vector3);
			public virtual bool intersectsSphere(Sphere sphere) => default(bool);
			public virtual double distanceToPlane(Plane plane) => default(double);
			public virtual Vector3 intersectPlane(Plane plane, Vector3 target) => default(Vector3);
			public virtual bool intersectsPlane(Plane plane) => default(bool);
			public virtual Vector3 intersectBox(Box3 box, Vector3 target) => default(Vector3);
			public virtual bool intersectsBox(Box3 box) => default(bool);
			public virtual Vector3 intersectTriangle(Vector3 a, Vector3 b, Vector3 c, bool backfaceCulling, Vector3 target) => default(Vector3);
			public virtual Ray applyMatrix4(Matrix4 matrix4) => default(Ray);
			public virtual bool equals(Ray ray) => default(bool);
			public virtual object isIntersectionBox(object b) => default(object);
			public virtual object isIntersectionPlane(object p) => default(object);
			public virtual object isIntersectionSphere(object s) => default(object);
			public Ray() { }
		}
		public partial class Sphere
		{
			public virtual Vector3 center { get; set; }
			public virtual double radius { get; set; }
			public Sphere(Vector3 center, double radius) { }
			public virtual Sphere set(Vector3 center, double radius) => default(Sphere);
			public virtual Sphere setFromPoints(Vector3[] points, Vector3 optionalCenter) => default(Sphere);
			public virtual Sphere clone() => default(Sphere);
			public virtual Sphere copy(Sphere sphere) => default(Sphere);
			public virtual bool empty() => default(bool);
			public virtual bool containsPoint(Vector3 point) => default(bool);
			public virtual double distanceToPoint(Vector3 point) => default(double);
			public virtual bool intersectsSphere(Sphere sphere) => default(bool);
			public virtual bool intersectsBox(Box3 box) => default(bool);
			public virtual bool intersectsPlane(Plane plane) => default(bool);
			public virtual Vector3 clampPoint(Vector3 point, Vector3 target) => default(Vector3);
			public virtual Box3 getBoundingBox(Box3 target) => default(Box3);
			public virtual Sphere applyMatrix4(Matrix4 matrix) => default(Sphere);
			public virtual Sphere translate(Vector3 offset) => default(Sphere);
			public virtual bool equals(Sphere sphere) => default(bool);
			public Sphere() { }
		}
		public partial interface SplineControlPoint
		{
			double x { get; set; }
			double y { get; set; }
			double z { get; set; }
		}
		public partial class Triangle
		{
			public virtual Vector3 a { get; set; }
			public virtual Vector3 b { get; set; }
			public virtual Vector3 c { get; set; }
			public Triangle(Vector3 a, Vector3 b, Vector3 c) { }
			public virtual Triangle set(Vector3 a, Vector3 b, Vector3 c) => default(Triangle);
			public virtual Triangle setFromPointsAndIndices(Vector3[] points, double i0, double i1, double i2) => default(Triangle);
			public virtual Triangle clone() => default(Triangle);
			public virtual Triangle copy(Triangle triangle) => default(Triangle);
			public virtual double getArea() => default(double);
			public virtual Vector3 getMidpoint(Vector3 target) => default(Vector3);
			public virtual Vector3 getNormal(Vector3 target) => default(Vector3);
			public virtual Plane getPlane(Vector3 target) => default(Plane);
			public virtual Vector3 getBarycoord(Vector3 point, Vector3 target) => default(Vector3);
			public virtual bool containsPoint(Vector3 point) => default(bool);
			public virtual Vector3 closestPointToPoint(Vector3 point, Vector3 target) => default(Vector3);
			public virtual bool equals(Triangle triangle) => default(bool);
			public virtual Vector3 getNormal(Vector3 a, Vector3 b, Vector3 c, Vector3 target) => default(Vector3);
			public virtual Vector3 getBarycoord(Vector3 point, Vector3 a, Vector3 b, Vector3 c, Vector3 target) => default(Vector3);
			public virtual bool containsPoint(Vector3 point, Vector3 a, Vector3 b, Vector3 c) => default(bool);
			public Triangle() { }
		}
		public partial interface Vector
		{
			Vector setComponent(double index, double value);
			double getComponent(double index);
			Vector set(double[] args);
			Vector setScalar(double scalar);
			Vector copy(Vector v);
			Vector add(Vector v, Vector w);
			Vector addVectors(Vector a, Vector b);
			Vector addScaledVector(Vector vector, double scale);
			Vector addScalar(double scalar);
			Vector sub(Vector v);
			Vector subVectors(Vector a, Vector b);
			Vector multiplyScalar(double s);
			Vector divideScalar(double s);
			Vector negate();
			double dot(Vector v);
			double lengthSq();
			double length();
			Vector normalize();
			double distanceTo(Vector v);
			double distanceToSquared(Vector v);
			Vector setLength(double l);
			Vector lerp(Vector v, double alpha);
			bool equals(Vector v);
			Vector clone();
		}
		public partial class Vector2 : Vector
		{
			public virtual double x { get; set; }
			public virtual double y { get; set; }
			public virtual double width { get; set; }
			public virtual double height { get; set; }
			public virtual bool isVector2 { get; set; }
			public Vector2(double x, double y) { }
			public virtual Vector2 set(double x, double y) => default(Vector2);
			public virtual Vector2 setScalar(double scalar) => default(Vector2);
			public virtual Vector2 setX(double x) => default(Vector2);
			public virtual Vector2 setY(double y) => default(Vector2);
			public virtual Vector2 setComponent(double index, double value) => default(Vector2);
			public virtual double getComponent(double index) => default(double);
			public virtual Vector2 clone() => default(Vector2);
			public virtual Vector2 copy(Vector2 v) => default(Vector2);
			public virtual Vector2 add(Vector2 v, Vector2 w) => default(Vector2);
			public virtual Vector2 addScalar(double s) => default(Vector2);
			public virtual Vector2 addVectors(Vector2 a, Vector2 b) => default(Vector2);
			public virtual Vector2 addScaledVector(Vector2 v, double s) => default(Vector2);
			public virtual Vector2 sub(Vector2 v) => default(Vector2);
			public virtual Vector2 subScalar(double s) => default(Vector2);
			public virtual Vector2 subVectors(Vector2 a, Vector2 b) => default(Vector2);
			public virtual Vector2 multiply(Vector2 v) => default(Vector2);
			public virtual Vector2 multiplyScalar(double scalar) => default(Vector2);
			public virtual Vector2 divide(Vector2 v) => default(Vector2);
			public virtual Vector2 divideScalar(double s) => default(Vector2);
			public virtual Vector2 applyMatrix3(Matrix3 m) => default(Vector2);
			public virtual Vector2 min(Vector2 v) => default(Vector2);
			public virtual Vector2 max(Vector2 v) => default(Vector2);
			public virtual Vector2 clamp(Vector2 min, Vector2 max) => default(Vector2);
			public virtual Vector2 clampScalar(double min, double max) => default(Vector2);
			public virtual Vector2 clampLength(double min, double max) => default(Vector2);
			public virtual Vector2 floor() => default(Vector2);
			public virtual Vector2 ceil() => default(Vector2);
			public virtual Vector2 round() => default(Vector2);
			public virtual Vector2 roundToZero() => default(Vector2);
			public virtual Vector2 negate() => default(Vector2);
			public virtual double dot(Vector2 v) => default(double);
			public virtual double lengthSq() => default(double);
			public virtual double length() => default(double);
			public virtual double lengthManhattan() => default(double);
			public virtual double manhattanLength() => default(double);
			public virtual Vector2 normalize() => default(Vector2);
			public virtual double angle() => default(double);
			public virtual double distanceTo(Vector2 v) => default(double);
			public virtual double distanceToSquared(Vector2 v) => default(double);
			public virtual double distanceToManhattan(Vector2 v) => default(double);
			public virtual double manhattanDistanceTo(Vector2 v) => default(double);
			public virtual Vector2 setLength(double length) => default(Vector2);
			public virtual Vector2 lerp(Vector2 v, double alpha) => default(Vector2);
			public virtual Vector2 lerpVectors(Vector2 v1, Vector2 v2, double alpha) => default(Vector2);
			public virtual bool equals(Vector2 v) => default(bool);
			public virtual Vector2 fromArray(double[] array, double offset) => default(Vector2);
			public virtual double[] toArray(double[] array, double offset) => default(double[]);
			public virtual ArrayLike<double> toArray(ArrayLike<double> array, double offset) => default(ArrayLike<double>);
			public virtual Vector2 fromBufferAttribute(BufferAttribute attribute, double index) => default(Vector2);
			public virtual Vector2 rotateAround(Vector2 center, double angle) => default(Vector2);
			public Vector2() { }
			Vector THREE.Vector.setComponent(double index, double value) => default(Vector);
			double THREE.Vector.getComponent(double index) => default(double);
			Vector THREE.Vector.set(double[] args) => default(Vector);
			Vector THREE.Vector.setScalar(double scalar) => default(Vector);
			Vector THREE.Vector.copy(Vector v) => default(Vector);
			Vector THREE.Vector.add(Vector v, Vector w) => default(Vector);
			Vector THREE.Vector.addVectors(Vector a, Vector b) => default(Vector);
			Vector THREE.Vector.addScaledVector(Vector vector, double scale) => default(Vector);
			Vector THREE.Vector.addScalar(double scalar) => default(Vector);
			Vector THREE.Vector.sub(Vector v) => default(Vector);
			Vector THREE.Vector.subVectors(Vector a, Vector b) => default(Vector);
			Vector THREE.Vector.multiplyScalar(double s) => default(Vector);
			Vector THREE.Vector.divideScalar(double s) => default(Vector);
			Vector THREE.Vector.negate() => default(Vector);
			double THREE.Vector.dot(Vector v) => default(double);
			double THREE.Vector.lengthSq() => default(double);
			double THREE.Vector.length() => default(double);
			Vector THREE.Vector.normalize() => default(Vector);
			double THREE.Vector.distanceTo(Vector v) => default(double);
			double THREE.Vector.distanceToSquared(Vector v) => default(double);
			Vector THREE.Vector.setLength(double l) => default(Vector);
			Vector THREE.Vector.lerp(Vector v, double alpha) => default(Vector);
			bool THREE.Vector.equals(Vector v) => default(bool);
			Vector THREE.Vector.clone() => default(Vector);
		}
		public partial class Vector3 : Vector
		{
			public virtual double x { get; set; }
			public virtual double y { get; set; }
			public virtual double z { get; set; }
			public virtual bool isVector3 { get; set; }
			public Vector3(double x, double y, double z) { }
			public virtual Vector3 set(double x, double y, double z) => default(Vector3);
			public virtual Vector3 setScalar(double scalar) => default(Vector3);
			public virtual Vector3 setX(double x) => default(Vector3);
			public virtual Vector3 setY(double y) => default(Vector3);
			public virtual Vector3 setZ(double z) => default(Vector3);
			public virtual Vector3 setComponent(double index, double value) => default(Vector3);
			public virtual double getComponent(double index) => default(double);
			public virtual Vector3 clone() => default(Vector3);
			public virtual Vector3 copy(Vector3 v) => default(Vector3);
			public virtual Vector3 add(Vector3 a, Vector3 b) => default(Vector3);
			public virtual Vector3 addScalar(double s) => default(Vector3);
			public virtual Vector3 addScaledVector(Vector3 v, double s) => default(Vector3);
			public virtual Vector3 addVectors(Vector3 a, Vector3 b) => default(Vector3);
			public virtual Vector3 sub(Vector3 a) => default(Vector3);
			public virtual Vector3 subScalar(double s) => default(Vector3);
			public virtual Vector3 subVectors(Vector3 a, Vector3 b) => default(Vector3);
			public virtual Vector3 multiply(Vector3 v) => default(Vector3);
			public virtual Vector3 multiplyScalar(double s) => default(Vector3);
			public virtual Vector3 multiplyVectors(Vector3 a, Vector3 b) => default(Vector3);
			public virtual Vector3 applyEuler(Euler euler) => default(Vector3);
			public virtual Vector3 applyAxisAngle(Vector3 axis, double angle) => default(Vector3);
			public virtual Vector3 applyMatrix3(Matrix3 m) => default(Vector3);
			public virtual Vector3 applyMatrix4(Matrix4 m) => default(Vector3);
			public virtual Vector3 applyQuaternion(Quaternion q) => default(Vector3);
			public virtual Vector3 project(Camera camera) => default(Vector3);
			public virtual Vector3 unproject(Camera camera) => default(Vector3);
			public virtual Vector3 transformDirection(Matrix4 m) => default(Vector3);
			public virtual Vector3 divide(Vector3 v) => default(Vector3);
			public virtual Vector3 divideScalar(double s) => default(Vector3);
			public virtual Vector3 min(Vector3 v) => default(Vector3);
			public virtual Vector3 max(Vector3 v) => default(Vector3);
			public virtual Vector3 clamp(Vector3 min, Vector3 max) => default(Vector3);
			public virtual Vector3 clampScalar(double min, double max) => default(Vector3);
			public virtual Vector3 clampLength(double min, double max) => default(Vector3);
			public virtual Vector3 floor() => default(Vector3);
			public virtual Vector3 ceil() => default(Vector3);
			public virtual Vector3 round() => default(Vector3);
			public virtual Vector3 roundToZero() => default(Vector3);
			public virtual Vector3 negate() => default(Vector3);
			public virtual double dot(Vector3 v) => default(double);
			public virtual double lengthSq() => default(double);
			public virtual double length() => default(double);
			public virtual double lengthManhattan() => default(double);
			public virtual double manhattanLength() => default(double);
			public virtual double manhattanDistanceTo(Vector3 v) => default(double);
			public virtual Vector3 normalize() => default(Vector3);
			public virtual Vector3 setLength(double l) => default(Vector3);
			public virtual Vector3 lerp(Vector3 v, double alpha) => default(Vector3);
			public virtual Vector3 lerpVectors(Vector3 v1, Vector3 v2, double alpha) => default(Vector3);
			public virtual Vector3 cross(Vector3 a, Vector3 w) => default(Vector3);
			public virtual Vector3 crossVectors(Vector3 a, Vector3 b) => default(Vector3);
			public virtual Vector3 projectOnVector(Vector3 v) => default(Vector3);
			public virtual Vector3 projectOnPlane(Vector3 planeNormal) => default(Vector3);
			public virtual Vector3 reflect(Vector3 vector) => default(Vector3);
			public virtual double angleTo(Vector3 v) => default(double);
			public virtual double distanceTo(Vector3 v) => default(double);
			public virtual double distanceToSquared(Vector3 v) => default(double);
			public virtual double distanceToManhattan(Vector3 v) => default(double);
			public virtual Vector3 setFromSpherical(Spherical s) => default(Vector3);
			public virtual Vector3 setFromCylindrical(Cylindrical s) => default(Vector3);
			public virtual Vector3 setFromMatrixPosition(Matrix4 m) => default(Vector3);
			public virtual Vector3 setFromMatrixScale(Matrix4 m) => default(Vector3);
			public virtual Vector3 setFromMatrixColumn(Matrix4 matrix, double index) => default(Vector3);
			public virtual bool equals(Vector3 v) => default(bool);
			public virtual Vector3 fromArray(double[] xyz, double offset) => default(Vector3);
			public virtual double[] toArray(double[] xyz, double offset) => default(double[]);
			public virtual ArrayLike<double> toArray(ArrayLike<double> xyz, double offset) => default(ArrayLike<double>);
			public virtual Vector3 fromBufferAttribute(BufferAttribute attribute, double index, double offset) => default(Vector3);
			public Vector3() { }
			Vector THREE.Vector.setComponent(double index, double value) => default(Vector);
			double THREE.Vector.getComponent(double index) => default(double);
			Vector THREE.Vector.set(double[] args) => default(Vector);
			Vector THREE.Vector.setScalar(double scalar) => default(Vector);
			Vector THREE.Vector.copy(Vector v) => default(Vector);
			Vector THREE.Vector.add(Vector v, Vector w) => default(Vector);
			Vector THREE.Vector.addVectors(Vector a, Vector b) => default(Vector);
			Vector THREE.Vector.addScaledVector(Vector vector, double scale) => default(Vector);
			Vector THREE.Vector.addScalar(double scalar) => default(Vector);
			Vector THREE.Vector.sub(Vector v) => default(Vector);
			Vector THREE.Vector.subVectors(Vector a, Vector b) => default(Vector);
			Vector THREE.Vector.multiplyScalar(double s) => default(Vector);
			Vector THREE.Vector.divideScalar(double s) => default(Vector);
			Vector THREE.Vector.negate() => default(Vector);
			double THREE.Vector.dot(Vector v) => default(double);
			double THREE.Vector.lengthSq() => default(double);
			double THREE.Vector.length() => default(double);
			Vector THREE.Vector.normalize() => default(Vector);
			double THREE.Vector.distanceTo(Vector v) => default(double);
			double THREE.Vector.distanceToSquared(Vector v) => default(double);
			Vector THREE.Vector.setLength(double l) => default(Vector);
			Vector THREE.Vector.lerp(Vector v, double alpha) => default(Vector);
			bool THREE.Vector.equals(Vector v) => default(bool);
			Vector THREE.Vector.clone() => default(Vector);
		}
		public partial class Vertex : Vector3
		{
			public Vertex() { }
		}
		public partial class Vector4 : Vector
		{
			public virtual double x { get; set; }
			public virtual double y { get; set; }
			public virtual double z { get; set; }
			public virtual double w { get; set; }
			public virtual bool isVector4 { get; set; }
			public Vector4(double x, double y, double z, double w) { }
			public virtual Vector4 set(double x, double y, double z, double w) => default(Vector4);
			public virtual Vector4 setScalar(double scalar) => default(Vector4);
			public virtual Vector4 setX(double x) => default(Vector4);
			public virtual Vector4 setY(double y) => default(Vector4);
			public virtual Vector4 setZ(double z) => default(Vector4);
			public virtual Vector4 setW(double w) => default(Vector4);
			public virtual Vector4 setComponent(double index, double value) => default(Vector4);
			public virtual double getComponent(double index) => default(double);
			public virtual Vector4 clone() => default(Vector4);
			public virtual Vector4 copy(Vector4 v) => default(Vector4);
			public virtual Vector4 add(Vector4 v, Vector4 w) => default(Vector4);
			public virtual Vector4 addScalar(double scalar) => default(Vector4);
			public virtual Vector4 addVectors(Vector4 a, Vector4 b) => default(Vector4);
			public virtual Vector4 addScaledVector(Vector4 v, double s) => default(Vector4);
			public virtual Vector4 sub(Vector4 v) => default(Vector4);
			public virtual Vector4 subScalar(double s) => default(Vector4);
			public virtual Vector4 subVectors(Vector4 a, Vector4 b) => default(Vector4);
			public virtual Vector4 multiplyScalar(double s) => default(Vector4);
			public virtual Vector4 applyMatrix4(Matrix4 m) => default(Vector4);
			public virtual Vector4 divideScalar(double s) => default(Vector4);
			public virtual Vector4 setAxisAngleFromQuaternion(Quaternion q) => default(Vector4);
			public virtual Vector4 setAxisAngleFromRotationMatrix(Matrix3 m) => default(Vector4);
			public virtual Vector4 min(Vector4 v) => default(Vector4);
			public virtual Vector4 max(Vector4 v) => default(Vector4);
			public virtual Vector4 clamp(Vector4 min, Vector4 max) => default(Vector4);
			public virtual Vector4 clampScalar(double min, double max) => default(Vector4);
			public virtual Vector4 floor() => default(Vector4);
			public virtual Vector4 ceil() => default(Vector4);
			public virtual Vector4 round() => default(Vector4);
			public virtual Vector4 roundToZero() => default(Vector4);
			public virtual Vector4 negate() => default(Vector4);
			public virtual double dot(Vector4 v) => default(double);
			public virtual double lengthSq() => default(double);
			public virtual double length() => default(double);
			public virtual double manhattanLength() => default(double);
			public virtual Vector4 normalize() => default(Vector4);
			public virtual Vector4 setLength(double length) => default(Vector4);
			public virtual Vector4 lerp(Vector4 v, double alpha) => default(Vector4);
			public virtual Vector4 lerpVectors(Vector4 v1, Vector4 v2, double alpha) => default(Vector4);
			public virtual bool equals(Vector4 v) => default(bool);
			public virtual Vector4 fromArray(double[] xyzw, double offset) => default(Vector4);
			public virtual double[] toArray(double[] xyzw, double offset) => default(double[]);
			public virtual Vector4 fromBufferAttribute(BufferAttribute attribute, double index, double offset) => default(Vector4);
			public Vector4() { }
			Vector THREE.Vector.setComponent(double index, double value) => default(Vector);
			double THREE.Vector.getComponent(double index) => default(double);
			Vector THREE.Vector.set(double[] args) => default(Vector);
			Vector THREE.Vector.setScalar(double scalar) => default(Vector);
			Vector THREE.Vector.copy(Vector v) => default(Vector);
			Vector THREE.Vector.add(Vector v, Vector w) => default(Vector);
			Vector THREE.Vector.addVectors(Vector a, Vector b) => default(Vector);
			Vector THREE.Vector.addScaledVector(Vector vector, double scale) => default(Vector);
			Vector THREE.Vector.addScalar(double scalar) => default(Vector);
			Vector THREE.Vector.sub(Vector v) => default(Vector);
			Vector THREE.Vector.subVectors(Vector a, Vector b) => default(Vector);
			Vector THREE.Vector.multiplyScalar(double s) => default(Vector);
			Vector THREE.Vector.divideScalar(double s) => default(Vector);
			Vector THREE.Vector.negate() => default(Vector);
			double THREE.Vector.dot(Vector v) => default(double);
			double THREE.Vector.lengthSq() => default(double);
			double THREE.Vector.length() => default(double);
			Vector THREE.Vector.normalize() => default(Vector);
			public virtual double distanceTo(Vector v) => default(double);
			public virtual double distanceToSquared(Vector v) => default(double);
			Vector THREE.Vector.setLength(double l) => default(Vector);
			Vector THREE.Vector.lerp(Vector v, double alpha) => default(Vector);
			bool THREE.Vector.equals(Vector v) => default(bool);
			Vector THREE.Vector.clone() => default(Vector);
		}
		public abstract partial class Interpolant
		{
			public virtual object parameterPositions { get; set; }
			public virtual object samplesValues { get; set; }
			public virtual double valueSize { get; set; }
			public virtual object resultBuffer { get; set; }
			public Interpolant(object parameterPositions, object samplesValues, double sampleSize, object resultBuffer) { }
			public virtual object evaluate(double time) => default(object);
			public Interpolant() { }
		}
		public partial class CubicInterpolant : Interpolant
		{
			public CubicInterpolant(object parameterPositions, object samplesValues, double sampleSize, object resultBuffer) { }
			public virtual object interpolate_(double i1, double t0, double t, double t1) => default(object);
			public CubicInterpolant() { }
		}
		public partial class DiscreteInterpolant : Interpolant
		{
			public DiscreteInterpolant(object parameterPositions, object samplesValues, double sampleSize, object resultBuffer) { }
			public virtual object interpolate_(double i1, double t0, double t, double t1) => default(object);
			public DiscreteInterpolant() { }
		}
		public partial class LinearInterpolant : Interpolant
		{
			public LinearInterpolant(object parameterPositions, object samplesValues, double sampleSize, object resultBuffer) { }
			public virtual object interpolate_(double i1, double t0, double t, double t1) => default(object);
			public LinearInterpolant() { }
		}
		public partial class QuaternionLinearInterpolant : Interpolant
		{
			public QuaternionLinearInterpolant(object parameterPositions, object samplesValues, double sampleSize, object resultBuffer) { }
			public virtual object interpolate_(double i1, double t0, double t, double t1) => default(object);
			public QuaternionLinearInterpolant() { }
		}
		public partial class Bone : Object3D
		{
			public class Bone_Type_0 : Enumerated
			{
				public static string Bone = "Bone";
				public static implicit operator Bone_Type_0(string value) { return new Bone_Type_0(value); }
				public Bone_Type_0(object value) { Value = value; }
			}
			public virtual bool isBone { get; set; }
			public virtual Bone_Type_0 type { get; set; }
			public Bone() { }
		}
		public partial class Group : Object3D
		{
			public class Group_Type_0 : Enumerated
			{
				public static string Group = "Group";
				public static implicit operator Group_Type_0(string value) { return new Group_Type_0(value); }
				public Group_Type_0(object value) { Value = value; }
			}
			public virtual Group_Type_0 type { get; set; }
			public virtual bool isGroup { get; set; }
			public Group() { }
		}
		public partial class LOD : Object3D
		{
			public class LOD_Type_0 : Enumerated
			{
				public static string LOD = "LOD";
				public static implicit operator LOD_Type_0(string value) { return new LOD_Type_0(value); }
				public LOD_Type_0(object value) { Value = value; }
			}
			public partial interface LOD_Type_1
			{
				double distance { get; set; }
				Object3D @object { get; set; }
			}
			public virtual LOD_Type_0 type { get; set; }
			public virtual LOD_Type_1[] levels { get; set; }
			public virtual object[] objects { get; set; }
			public LOD() { }
			public virtual void addLevel(Object3D @object, double distance) { }
			public virtual Object3D getObjectForDistance(double distance) => default(Object3D);
			public virtual void raycast(Raycaster raycaster, Intersection[] intersects) { }
			public virtual void update(Camera camera) { }
			public virtual object toJSON(object meta) => default(object);
		}
		public partial class Line : Object3D
		{
			public class Line_Type_0 : Enumerated
			{
				public static string Line = "Line";
				public static string LineLoop = "LineLoop";
				public static string LineSegments = "LineSegments";
				public static implicit operator Line_Type_0(string value) { return new Line_Type_0(value); }
				public Line_Type_0(object value) { Value = value; }
			}
			public virtual Union<Geometry, BufferGeometry> geometry { get; set; }
			public virtual Union<Material, Material[]> material { get; set; }
			public virtual Line_Type_0 type { get; set; }
			public virtual bool isLine { get; set; }
			public Line(Union<Geometry, BufferGeometry> geometry, Union<Material, Material[]> material, double mode) { }
			public virtual Line computeLineDistances() => default(Line);
			public virtual void raycast(Raycaster raycaster, Intersection[] intersects) { }
			public Line() { }
		}
		public partial class LineLoop : Line
		{
			public class LineLoop_Type_0 : Enumerated
			{
				public static string LineLoop = "LineLoop";
				public static implicit operator LineLoop_Type_0(string value) { return new LineLoop_Type_0(value); }
				public LineLoop_Type_0(object value) { Value = value; }
			}
			public virtual LineLoop_Type_0 type { get; set; }
			public virtual bool isLineLoop { get; set; }
			public LineLoop(Union<Geometry, BufferGeometry> geometry, Union<Material, Material[]> material) { }
			public LineLoop() { }
		}
		public virtual double LineStrip { get; set; }
		public virtual double LinePieces { get; set; }
		public partial class LineSegments : Line
		{
			public class LineSegments_Type_0 : Enumerated
			{
				public static string LineSegments = "LineSegments";
				public static implicit operator LineSegments_Type_0(string value) { return new LineSegments_Type_0(value); }
				public LineSegments_Type_0(object value) { Value = value; }
			}
			public virtual LineSegments_Type_0 type { get; set; }
			public virtual bool isLineSegments { get; set; }
			public LineSegments(Union<Geometry, BufferGeometry> geometry, Union<Material, Material[]> material, double mode) { }
			public LineSegments() { }
		}
		public partial class Mesh : Object3D
		{
			public partial interface Mesh_Type_0
			{
				double this[string key] { get; set; }
			}
			public virtual Union<Geometry, BufferGeometry> geometry { get; set; }
			public virtual Union<Material, Material[]> material { get; set; }
			public virtual TrianglesDrawModes drawMode { get; set; }
			public virtual double[] morphTargetInfluences { get; set; }
			public virtual Mesh_Type_0 morphTargetDictionary { get; set; }
			public virtual bool isMesh { get; set; }
			public virtual string type { get; set; }
			public Mesh(Union<Geometry, BufferGeometry> geometry, Union<Material, Material[]> material) { }
			public virtual void setDrawMode(TrianglesDrawModes drawMode) { }
			public virtual void updateMorphTargets() { }
			public virtual void raycast(Raycaster raycaster, Intersection[] intersects) { }
			public virtual Mesh copy(Mesh source, bool recursive) => default(Mesh);
			public Mesh() { }
		}
		public partial class Points : Object3D
		{
			public class Points_Type_0 : Enumerated
			{
				public static string Points = "Points";
				public static implicit operator Points_Type_0(string value) { return new Points_Type_0(value); }
				public Points_Type_0(object value) { Value = value; }
			}
			public virtual Points_Type_0 type { get; set; }
			public virtual bool isPoints { get; set; }
			public virtual Union<Geometry, BufferGeometry> geometry { get; set; }
			public virtual Union<Material, Material[]> material { get; set; }
			public Points(Union<Geometry, BufferGeometry> geometry, Union<Material, Material[]> material) { }
			public virtual void raycast(Raycaster raycaster, Intersection[] intersects) { }
			public Points() { }
		}
		public partial class PointCloud : Points
		{
			public PointCloud() { }
		}
		public partial class ParticleSystem : Points
		{
			public ParticleSystem() { }
		}
		public partial class Skeleton
		{
			public virtual bool useVertexTexture { get; set; }
			public virtual Matrix4 identityMatrix { get; set; }
			public virtual Bone[] bones { get; set; }
			public virtual double boneTextureWidth { get; set; }
			public virtual double boneTextureHeight { get; set; }
			public virtual Float32Array boneMatrices { get; set; }
			public virtual DataTexture boneTexture { get; set; }
			public virtual Matrix4[] boneInverses { get; set; }
			public Skeleton(Bone[] bones, Matrix4[] boneInverses) { }
			public virtual void calculateInverses(Bone bone) { }
			public virtual void pose() { }
			public virtual void update() { }
			public virtual Skeleton clone() => default(Skeleton);
			public Skeleton() { }
		}
		public partial class SkinnedMesh : Mesh
		{
			public virtual string bindMode { get; set; }
			public virtual Matrix4 bindMatrix { get; set; }
			public virtual Matrix4 bindMatrixInverse { get; set; }
			public virtual Skeleton skeleton { get; set; }
			public SkinnedMesh(Union<Geometry, BufferGeometry> geometry, Union<Material, Material[]> material, bool useVertexTexture) { }
			public virtual void bind(Skeleton skeleton, Matrix4 bindMatrix) { }
			public virtual void pose() { }
			public virtual void normalizeSkinWeights() { }
			public virtual void updateMatrixWorld(bool force) { }
			public SkinnedMesh() { }
		}
		public partial class Sprite : Object3D
		{
			public class Sprite_Type_0 : Enumerated
			{
				public static string Sprite = "Sprite";
				public static implicit operator Sprite_Type_0(string value) { return new Sprite_Type_0(value); }
				public Sprite_Type_0(object value) { Value = value; }
			}
			public virtual Sprite_Type_0 type { get; set; }
			public virtual bool isSprite { get; set; }
			public virtual Material material { get; set; }
			public virtual Vector2 center { get; set; }
			public Sprite(Material material) { }
			public virtual void raycast(Raycaster raycaster, Intersection[] intersects) { }
			public virtual Sprite copy(Sprite source, bool recursive) => default(Sprite);
			public Sprite() { }
		}
		public partial class Particle : Sprite
		{
			public Particle() { }
		}
		public partial interface Renderer
		{
			HTMLCanvasElement domElement { get; set; }
			void render(Scene scene, Camera camera);
			void setSize(double width, double height, bool updateStyle);
		}
		public partial interface WebGLRendererParameters
		{
			HTMLCanvasElement canvas { get; set; }
			WebGLRenderingContext context { get; set; }
			string precision { get; set; }
			bool alpha { get; set; }
			bool premultipliedAlpha { get; set; }
			bool antialias { get; set; }
			bool stencil { get; set; }
			bool preserveDrawingBuffer { get; set; }
			string powerPreference { get; set; }
			bool depth { get; set; }
			bool logarithmicDepthBuffer { get; set; }
		}
		public partial class WebGLRenderer : Renderer
		{
			public partial interface WebGLRenderer_Type_0
			{
				double width { get; set; }
				double height { get; set; }
			}
			public partial interface WebGLRenderer_Type_1
			{
				double width { get; set; }
				double height { get; set; }
			}
			public virtual HTMLCanvasElement domElement { get; set; }
			public virtual WebGLRenderingContext context { get; set; }
			public virtual bool autoClear { get; set; }
			public virtual bool autoClearColor { get; set; }
			public virtual bool autoClearDepth { get; set; }
			public virtual bool autoClearStencil { get; set; }
			public virtual bool sortObjects { get; set; }
			public virtual object[] clippingPlanes { get; set; }
			public virtual bool localClippingEnabled { get; set; }
			public virtual WebGLExtensions extensions { get; set; }
			public virtual bool gammaInput { get; set; }
			public virtual bool gammaOutput { get; set; }
			public virtual bool physicallyCorrectLights { get; set; }
			public virtual ToneMapping toneMapping { get; set; }
			public virtual double toneMappingExposure { get; set; }
			public virtual double toneMappingWhitePoint { get; set; }
			public virtual bool shadowMapDebug { get; set; }
			public virtual double maxMorphTargets { get; set; }
			public virtual double maxMorphNormals { get; set; }
			public virtual WebGLInfo info { get; set; }
			public virtual WebGLShadowMap shadowMap { get; set; }
			public virtual double pixelRation { get; set; }
			public virtual WebGLCapabilities capabilities { get; set; }
			public virtual WebGLProperties properties { get; set; }
			public virtual WebGLRenderLists renderLists { get; set; }
			public virtual WebGLState state { get; set; }
			public virtual object allocTextureUnit { get; set; }
			public virtual WebVRManager vr { get; set; }
			public virtual double gammaFactor { get; set; }
			public virtual bool shadowMapEnabled { get; set; }
			public virtual ShadowMapType shadowMapType { get; set; }
			public virtual CullFace shadowMapCullFace { get; set; }
			public WebGLRenderer(WebGLRendererParameters parameters) { }
			public virtual WebGLRenderingContext getContext() => default(WebGLRenderingContext);
			public virtual object getContextAttributes() => default(object);
			public virtual void forceContextLoss() { }
			public virtual double getMaxAnisotropy() => default(double);
			public virtual string getPrecision() => default(string);
			public virtual double getPixelRatio() => default(double);
			public virtual void setPixelRatio(double value) { }
			public virtual WebGLRenderer_Type_0 getDrawingBufferSize() => default(WebGLRenderer_Type_0);
			public virtual void setDrawingBufferSize(double width, double height, double pixelRatio) { }
			public virtual WebGLRenderer_Type_1 getSize() => default(WebGLRenderer_Type_1);
			public virtual void setSize(double width, double height, bool updateStyle) { }
			public virtual Vector4 getCurrentViewport() => default(Vector4);
			public virtual void setViewport(double x, double y, double width, double height) { }
			public virtual void setScissor(double x, double y, double width, double height) { }
			public virtual void setScissorTest(bool enable) { }
			public virtual Color getClearColor() => default(Color);
			public virtual void setClearColor(Color color, double alpha) { }
			public virtual void setClearColor(string color, double alpha) { }
			public virtual void setClearColor(double color, double alpha) { }
			public virtual double getClearAlpha() => default(double);
			public virtual void setClearAlpha(double alpha) { }
			public virtual void clear(bool color, bool depth, bool stencil) { }
			public virtual void clearColor() { }
			public virtual void clearDepth() { }
			public virtual void clearStencil() { }
			public virtual void clearTarget(WebGLRenderTarget renderTarget, bool color, bool depth, bool stencil) { }
			public virtual void resetGLState() { }
			public virtual void dispose() { }
			public virtual void renderBufferImmediate(Object3D @object, Object program, Material material) { }
			public virtual void renderBufferDirect(Camera camera, Fog fog, Material material, object geometryGroup, Object3D @object) { }
			public virtual void setAnimationLoop(Function callback) { }
			public virtual void animate(Function callback) { }
			public virtual void render(Scene scene, Camera camera, RenderTarget renderTarget, bool forceClear) { }
			public virtual void setTexture(Texture texture, double slot) { }
			public virtual void setTexture2D(Texture texture, double slot) { }
			public virtual void setTextureCube(Texture texture, double slot) { }
			public virtual RenderTarget getRenderTarget() => default(RenderTarget);
			public virtual RenderTarget getCurrentRenderTarget() => default(RenderTarget);
			public virtual void setRenderTarget(RenderTarget renderTarget) { }
			public virtual void readRenderTargetPixels(RenderTarget renderTarget, double x, double y, double width, double height, object buffer) { }
			public virtual object supportsFloatTextures() => default(object);
			public virtual object supportsHalfFloatTextures() => default(object);
			public virtual object supportsStandardDerivatives() => default(object);
			public virtual object supportsCompressedTextureS3TC() => default(object);
			public virtual object supportsCompressedTexturePVRTC() => default(object);
			public virtual object supportsBlendMinMax() => default(object);
			public virtual object supportsVertexTextures() => default(object);
			public virtual object supportsInstancedArrays() => default(object);
			public virtual object enableScissorTest(object boolean) => default(object);
			public WebGLRenderer() { }
			void THREE.Renderer.render(Scene scene, Camera camera) { }
			void THREE.Renderer.setSize(double width, double height, bool updateStyle) { }
		}
		public partial interface RenderTarget
		{
		}
		public partial interface RenderItem
		{
			double id { get; set; }
			Object3D @object { get; set; }
			Union<Geometry, BufferGeometry> geometry { get; set; }
			Material material { get; set; }
			WebGLProgram program { get; set; }
			double renderOrder { get; set; }
			double z { get; set; }
			Group group { get; set; }
		}
		public partial class WebGLRenderList
		{
			public virtual RenderItem[] opaque { get; set; }
			public virtual object[] transparent { get; set; }
			public virtual void init() { }
			public virtual void push(Object3D @object, Union<Geometry, BufferGeometry> geometry, Material material, double z, Group group) { }
			public virtual void sort() { }
			public WebGLRenderList() { }
		}
		public partial class WebGLRenderLists
		{
			public virtual void dispose() { }
			public virtual WebGLRenderList get(Scene scene, Camera camera) => default(WebGLRenderList);
			public WebGLRenderLists() { }
		}
		public partial interface WebGLRenderTargetOptions
		{
			Wrapping wrapS { get; set; }
			Wrapping wrapT { get; set; }
			TextureFilter magFilter { get; set; }
			TextureFilter minFilter { get; set; }
			double format { get; set; }
			TextureDataType type { get; set; }
			double anisotropy { get; set; }
			bool depthBuffer { get; set; }
			bool stencilBuffer { get; set; }
			bool generateMipmaps { get; set; }
		}
		public partial class WebGLRenderTarget : EventDispatcher
		{
			public virtual string uuid { get; set; }
			public virtual double width { get; set; }
			public virtual double height { get; set; }
			public virtual Vector4 scissor { get; set; }
			public virtual bool scissorTest { get; set; }
			public virtual Vector4 viewport { get; set; }
			public virtual Texture texture { get; set; }
			public virtual bool depthBuffer { get; set; }
			public virtual bool stencilBuffer { get; set; }
			public virtual Texture depthTexture { get; set; }
			public virtual object wrapS { get; set; }
			public virtual object wrapT { get; set; }
			public virtual object magFilter { get; set; }
			public virtual object minFilter { get; set; }
			public virtual object anisotropy { get; set; }
			public virtual object offset { get; set; }
			public virtual object repeat { get; set; }
			public virtual object format { get; set; }
			public virtual object type { get; set; }
			public virtual object generateMipmaps { get; set; }
			public WebGLRenderTarget(double width, double height, WebGLRenderTargetOptions options) { }
			public virtual void setSize(double width, double height) { }
			public virtual WebGLRenderTarget clone() => default(WebGLRenderTarget);
			public virtual WebGLRenderTarget copy(WebGLRenderTarget source) => default(WebGLRenderTarget);
			public virtual void dispose() { }
			public WebGLRenderTarget() { }
		}
		public partial class WebGLRenderTargetCube : WebGLRenderTarget
		{
			public virtual double activeCubeFace { get; set; }
			public virtual double activeMipMapLevel { get; set; }
			public WebGLRenderTargetCube(double width, double height, WebGLRenderTargetOptions options) { }
			public WebGLRenderTargetCube() { }
		}
		public partial interface THREE_Type_0
		{
			string alphamap_fragment { get; set; }
			string alphamap_pars_fragment { get; set; }
			string alphatest_fragment { get; set; }
			string aomap_fragment { get; set; }
			string aomap_pars_fragment { get; set; }
			string begin_vertex { get; set; }
			string beginnormal_vertex { get; set; }
			string bsdfs { get; set; }
			string bumpmap_pars_fragment { get; set; }
			string clipping_planes_fragment { get; set; }
			string clipping_planes_pars_fragment { get; set; }
			string clipping_planes_pars_vertex { get; set; }
			string clipping_planes_vertex { get; set; }
			string color_fragment { get; set; }
			string color_pars_fragment { get; set; }
			string color_pars_vertex { get; set; }
			string color_vertex { get; set; }
			string common { get; set; }
			string cube_frag { get; set; }
			string cube_vert { get; set; }
			string cube_uv_reflection_fragment { get; set; }
			string defaultnormal_vertex { get; set; }
			string depth_frag { get; set; }
			string depth_vert { get; set; }
			string distanceRGBA_frag { get; set; }
			string distanceRGBA_vert { get; set; }
			string displacementmap_vertex { get; set; }
			string displacementmap_pars_vertex { get; set; }
			string emissivemap_fragment { get; set; }
			string emissivemap_pars_fragment { get; set; }
			string encodings_pars_fragment { get; set; }
			string encodings_fragment { get; set; }
			string envmap_fragment { get; set; }
			string envmap_pars_fragment { get; set; }
			string envmap_pars_vertex { get; set; }
			string envmap_vertex { get; set; }
			string equirect_frag { get; set; }
			string equirect_vert { get; set; }
			string fog_fragment { get; set; }
			string fog_pars_fragment { get; set; }
			string linedashed_frag { get; set; }
			string linedashed_vert { get; set; }
			string lightmap_fragment { get; set; }
			string lightmap_pars_fragment { get; set; }
			string lights_lambert_vertex { get; set; }
			string lights_pars_begin { get; set; }
			string lights_pars_map { get; set; }
			string lights_phong_fragment { get; set; }
			string lights_phong_pars_fragment { get; set; }
			string lights_physical_fragment { get; set; }
			string lights_physical_pars_fragment { get; set; }
			string lights_fragment_begin { get; set; }
			string lights_fragment_maps { get; set; }
			string lights_fragment_end { get; set; }
			string logdepthbuf_fragment { get; set; }
			string logdepthbuf_pars_fragment { get; set; }
			string logdepthbuf_pars_vertex { get; set; }
			string logdepthbuf_vertex { get; set; }
			string map_fragment { get; set; }
			string map_pars_fragment { get; set; }
			string map_particle_fragment { get; set; }
			string map_particle_pars_fragment { get; set; }
			string meshbasic_frag { get; set; }
			string meshbasic_vert { get; set; }
			string meshlambert_frag { get; set; }
			string meshlambert_vert { get; set; }
			string meshphong_frag { get; set; }
			string meshphong_vert { get; set; }
			string meshphysical_frag { get; set; }
			string meshphysical_vert { get; set; }
			string metalnessmap_fragment { get; set; }
			string metalnessmap_pars_fragment { get; set; }
			string morphnormal_vertex { get; set; }
			string morphtarget_pars_vertex { get; set; }
			string morphtarget_vertex { get; set; }
			string normal_flip { get; set; }
			string normal_frag { get; set; }
			string normal_fragment_begin { get; set; }
			string normal_fragment_maps { get; set; }
			string normal_vert { get; set; }
			string normalmap_pars_fragment { get; set; }
			string packing { get; set; }
			string points_frag { get; set; }
			string points_vert { get; set; }
			string shadow_frag { get; set; }
			string shadow_vert { get; set; }
			string premultiplied_alpha_fragment { get; set; }
			string project_vertex { get; set; }
			string roughnessmap_fragment { get; set; }
			string roughnessmap_pars_fragment { get; set; }
			string shadowmap_pars_fragment { get; set; }
			string shadowmap_pars_vertex { get; set; }
			string shadowmap_vertex { get; set; }
			string shadowmask_pars_fragment { get; set; }
			string skinbase_vertex { get; set; }
			string skinning_pars_vertex { get; set; }
			string skinning_vertex { get; set; }
			string skinnormal_vertex { get; set; }
			string specularmap_fragment { get; set; }
			string specularmap_pars_fragment { get; set; }
			string tonemapping_fragment { get; set; }
			string tonemapping_pars_fragment { get; set; }
			string uv2_pars_fragment { get; set; }
			string uv2_pars_vertex { get; set; }
			string uv2_vertex { get; set; }
			string uv_pars_fragment { get; set; }
			string uv_pars_vertex { get; set; }
			string uv_vertex { get; set; }
			string worldpos_vertex { get; set; }
			string this[string name] { get; set; }
		}
		public virtual THREE_Type_0 ShaderChunk { get; set; }
		public partial interface Shader
		{
			Shader_Type_0 uniforms { get; set; }
			string vertexShader { get; set; }
			string fragmentShader { get; set; }
		}
		public partial interface Shader_Type_0
		{
			IUniform this[string uniform] { get; set; }
		}
		public partial interface THREE_Type_1
		{
			Shader basic { get; set; }
			Shader lambert { get; set; }
			Shader phong { get; set; }
			Shader standard { get; set; }
			Shader points { get; set; }
			Shader dashed { get; set; }
			Shader depth { get; set; }
			Shader normal { get; set; }
			Shader cube { get; set; }
			Shader equirect { get; set; }
			Shader depthRGBA { get; set; }
			Shader distanceRGBA { get; set; }
			Shader physical { get; set; }
			Shader this[string name] { get; set; }
		}
		public virtual THREE_Type_1 ShaderLib { get; set; }
		public partial interface IUniform
		{
			object value { get; set; }
		}
		public partial interface THREE_Type_2
		{
			THREE_Type_2_Type_0 common { get; set; }
			THREE_Type_2_Type_1 specularmap { get; set; }
			THREE_Type_2_Type_2 envmap { get; set; }
			THREE_Type_2_Type_3 aomap { get; set; }
			THREE_Type_2_Type_4 lightmap { get; set; }
			THREE_Type_2_Type_5 emissivemap { get; set; }
			THREE_Type_2_Type_6 bumpmap { get; set; }
			THREE_Type_2_Type_7 normalmap { get; set; }
			THREE_Type_2_Type_8 displacementmap { get; set; }
			THREE_Type_2_Type_9 roughnessmap { get; set; }
			THREE_Type_2_Type_10 metalnessmap { get; set; }
			THREE_Type_2_Type_11 gradientmap { get; set; }
			THREE_Type_2_Type_12 fog { get; set; }
			THREE_Type_2_Type_13 lights { get; set; }
			THREE_Type_2_Type_14 points { get; set; }
		}
		public partial interface THREE_Type_2_Type_0
		{
			IUniform diffuse { get; set; }
			IUniform opacity { get; set; }
			IUniform map { get; set; }
			IUniform uvTransform { get; set; }
			IUniform alphaMap { get; set; }
		}
		public partial interface THREE_Type_2_Type_1
		{
			IUniform specularMap { get; set; }
		}
		public partial interface THREE_Type_2_Type_2
		{
			IUniform envMap { get; set; }
			IUniform flipEnvMap { get; set; }
			IUniform reflectivity { get; set; }
			IUniform refractionRatio { get; set; }
			IUniform maxMipLevel { get; set; }
		}
		public partial interface THREE_Type_2_Type_3
		{
			IUniform aoMap { get; set; }
			IUniform aoMapIntensity { get; set; }
		}
		public partial interface THREE_Type_2_Type_4
		{
			IUniform lightMap { get; set; }
			IUniform lightMapIntensity { get; set; }
		}
		public partial interface THREE_Type_2_Type_5
		{
			IUniform emissiveMap { get; set; }
		}
		public partial interface THREE_Type_2_Type_6
		{
			IUniform bumpMap { get; set; }
			IUniform bumpScale { get; set; }
		}
		public partial interface THREE_Type_2_Type_7
		{
			IUniform normalMap { get; set; }
			IUniform normalScale { get; set; }
		}
		public partial interface THREE_Type_2_Type_8
		{
			IUniform displacementMap { get; set; }
			IUniform displacementScale { get; set; }
			IUniform displacementBias { get; set; }
		}
		public partial interface THREE_Type_2_Type_9
		{
			IUniform roughnessMap { get; set; }
		}
		public partial interface THREE_Type_2_Type_10
		{
			IUniform metalnessMap { get; set; }
		}
		public partial interface THREE_Type_2_Type_11
		{
			IUniform gradientMap { get; set; }
		}
		public partial interface THREE_Type_2_Type_12
		{
			IUniform fogDensity { get; set; }
			IUniform fogNear { get; set; }
			IUniform fogFar { get; set; }
			IUniform fogColor { get; set; }
		}
		public partial interface THREE_Type_2_Type_13
		{
			IUniform ambientLightColor { get; set; }
			THREE_Type_2_Type_13_Type_0 directionalLights { get; set; }
			IUniform directionalShadowMap { get; set; }
			IUniform directionalShadowMatrix { get; set; }
			THREE_Type_2_Type_13_Type_1 spotLights { get; set; }
			IUniform spotShadowMap { get; set; }
			IUniform spotShadowMatrix { get; set; }
			THREE_Type_2_Type_13_Type_2 pointLights { get; set; }
			IUniform pointShadowMap { get; set; }
			IUniform pointShadowMatrix { get; set; }
			THREE_Type_2_Type_13_Type_3 hemisphereLights { get; set; }
			THREE_Type_2_Type_13_Type_4 rectAreaLights { get; set; }
		}
		public partial interface THREE_Type_2_Type_13_Type_0
		{
			object[] value { get; set; }
			THREE_Type_2_Type_13_Type_0_Type_0 properties { get; set; }
		}
		public partial interface THREE_Type_2_Type_13_Type_0_Type_0
		{
			object direction { get; set; }
			object color { get; set; }
			object shadow { get; set; }
			object shadowBias { get; set; }
			object shadowRadius { get; set; }
			object shadowMapSize { get; set; }
		}
		public partial interface THREE_Type_2_Type_13_Type_1
		{
			object[] value { get; set; }
			THREE_Type_2_Type_13_Type_1_Type_0 properties { get; set; }
		}
		public partial interface THREE_Type_2_Type_13_Type_1_Type_0
		{
			object color { get; set; }
			object position { get; set; }
			object direction { get; set; }
			object distance { get; set; }
			object coneCos { get; set; }
			object penumbraCos { get; set; }
			object decay { get; set; }
			object shadow { get; set; }
			object shadowBias { get; set; }
			object shadowRadius { get; set; }
			object shadowMapSize { get; set; }
		}
		public partial interface THREE_Type_2_Type_13_Type_2
		{
			object[] value { get; set; }
			THREE_Type_2_Type_13_Type_2_Type_0 properties { get; set; }
		}
		public partial interface THREE_Type_2_Type_13_Type_2_Type_0
		{
			object color { get; set; }
			object position { get; set; }
			object decay { get; set; }
			object distance { get; set; }
			object shadow { get; set; }
			object shadowBias { get; set; }
			object shadowRadius { get; set; }
			object shadowMapSize { get; set; }
		}
		public partial interface THREE_Type_2_Type_13_Type_3
		{
			object[] value { get; set; }
			THREE_Type_2_Type_13_Type_3_Type_0 properties { get; set; }
		}
		public partial interface THREE_Type_2_Type_13_Type_3_Type_0
		{
			object direction { get; set; }
			object skycolor { get; set; }
			object groundColor { get; set; }
		}
		public partial interface THREE_Type_2_Type_13_Type_4
		{
			object[] value { get; set; }
			THREE_Type_2_Type_13_Type_4_Type_0 properties { get; set; }
		}
		public partial interface THREE_Type_2_Type_13_Type_4_Type_0
		{
			object color { get; set; }
			object position { get; set; }
			object width { get; set; }
			object height { get; set; }
		}
		public partial interface THREE_Type_2_Type_14
		{
			IUniform diffuse { get; set; }
			IUniform opacity { get; set; }
			IUniform size { get; set; }
			IUniform scale { get; set; }
			IUniform map { get; set; }
			IUniform uvTransform { get; set; }
		}
		public virtual THREE_Type_2 UniformsLib { get; set; }
		public partial class UniformsUtils
		{
			public virtual object merge(object[] uniforms) => default(object);
			public virtual object clone(object uniforms_src) => default(object);
			public UniformsUtils() { }
		}
		public partial class Uniform
		{
			public virtual string type { get; set; }
			public virtual object value { get; set; }
			public virtual bool dynamic { get; set; }
			public virtual Function onUpdateCallback { get; set; }
			public Uniform(object value) { }
			public Uniform(string type, object value) { }
			public virtual Uniform onUpdate(Function callback) => default(Uniform);
			public Uniform() { }
		}
		public partial class WebGLBufferRenderer
		{
			public WebGLBufferRenderer(WebGLRenderingContext _gl, object extensions, object _infoRender) { }
			public virtual void setMode(object value) { }
			public virtual void render(object start, double count) { }
			public virtual void renderInstances(object geometry) { }
			public WebGLBufferRenderer() { }
		}
		public partial class WebGLClipping
		{
			public partial interface WebGLClipping_Type_0
			{
				object value { get; set; }
				bool needsUpdate { get; set; }
			}
			public virtual WebGLClipping_Type_0 uniform { get; set; }
			public virtual double numPlanes { get; set; }
			public virtual bool init(object[] planes, bool enableLocalClipping, Camera camera) => default(bool);
			public virtual void beginShadows() { }
			public virtual void endShadows() { }
			public virtual void setState(object[] planes, bool clipShadows, Camera camera, bool cache, bool fromCache) { }
			public WebGLClipping() { }
		}
		public partial interface WebGLCapabilitiesParameters
		{
			object precision { get; set; }
			object logarithmicDepthBuffer { get; set; }
		}
		public partial class WebGLCapabilities
		{
			public virtual object precision { get; set; }
			public virtual object logarithmicDepthBuffer { get; set; }
			public virtual object maxTextures { get; set; }
			public virtual object maxVertexTextures { get; set; }
			public virtual object maxTextureSize { get; set; }
			public virtual object maxCubemapSize { get; set; }
			public virtual object maxAttributes { get; set; }
			public virtual object maxVertexUniforms { get; set; }
			public virtual object maxVaryings { get; set; }
			public virtual object maxFragmentUniforms { get; set; }
			public virtual object vertexTextures { get; set; }
			public virtual object floatFragmentTextures { get; set; }
			public virtual object floatVertexTextures { get; set; }
			public WebGLCapabilities(WebGLRenderingContext gl, object extensions, WebGLCapabilitiesParameters parameters) { }
			public virtual double getMaxAnisotropy() => default(double);
			public virtual string getMaxPrecision(string precision) => default(string);
			public WebGLCapabilities() { }
		}
		public partial class WebGLExtensions
		{
			public WebGLExtensions(WebGLRenderingContext gl) { }
			public virtual object get(string name) => default(object);
			public WebGLExtensions() { }
		}
		public partial class WebGLGeometries
		{
			public WebGLGeometries(WebGLRenderingContext gl, object extensions, object _infoRender) { }
			public virtual object get(object @object) => default(object);
			public WebGLGeometries() { }
		}
		public partial class WebGLLights
		{
			public WebGLLights(WebGLRenderingContext gl, object properties, object info) { }
			public virtual object get(object light) => default(object);
			public WebGLLights() { }
		}
		public partial class WebGLInfo
		{
			public partial interface WebGLInfo_Type_0
			{
				double geometries { get; set; }
				double textures { get; set; }
			}
			public partial interface WebGLInfo_Type_1
			{
				double calls { get; set; }
				double frame { get; set; }
				double lines { get; set; }
				double points { get; set; }
				double triangles { get; set; }
			}
			public virtual bool autoReset { get; set; }
			public virtual WebGLInfo_Type_0 memory { get; set; }
			public virtual Union<WebGLProgram[], object> programs { get; set; }
			public virtual WebGLInfo_Type_1 render { get; set; }
			public virtual void reset() { }
			public WebGLInfo() { }
		}
		public partial class WebGLIndexedBufferRenderer
		{
			public WebGLIndexedBufferRenderer(WebGLRenderingContext gl, object properties, object info) { }
			public virtual void setMode(object value) { }
			public virtual void setIndex(object index) { }
			public virtual void render(object start, double count) { }
			public virtual void renderInstances(object geometry, object start, double count) { }
			public WebGLIndexedBufferRenderer() { }
		}
		public partial class WebGLObjects
		{
			public WebGLObjects(WebGLRenderingContext gl, object properties, object info) { }
			public virtual object getAttributeBuffer(object attribute) => default(object);
			public virtual object getWireframeAttribute(object geometry) => default(object);
			public virtual void update(object @object) { }
			public WebGLObjects() { }
		}
		public partial class WebGLProgram
		{
			public virtual double id { get; set; }
			public virtual string code { get; set; }
			public virtual double usedTimes { get; set; }
			public virtual object program { get; set; }
			public virtual WebGLShader vertexShader { get; set; }
			public virtual WebGLShader fragmentShader { get; set; }
			public virtual object uniforms { get; set; }
			public virtual object attributes { get; set; }
			public WebGLProgram(WebGLRenderer renderer, string code, ShaderMaterial material, WebGLRendererParameters parameters) { }
			public virtual WebGLUniforms getUniforms() => default(WebGLUniforms);
			public virtual object getAttributes() => default(object);
			public virtual void destroy() { }
			public WebGLProgram() { }
		}
		public partial class WebGLPrograms
		{
			public virtual WebGLProgram[] programs { get; set; }
			public WebGLPrograms(WebGLRenderer renderer, object capabilities) { }
			public virtual object getParameters(ShaderMaterial material, object lights, object fog, double nClipPlanes, object @object) => default(object);
			public virtual string getProgramCode(ShaderMaterial material, object parameters) => default(string);
			public virtual WebGLProgram acquireProgram(ShaderMaterial material, object parameters, string code) => default(WebGLProgram);
			public virtual void releaseProgram(WebGLProgram program) { }
			public WebGLPrograms() { }
		}
		public partial class WebGLTextures
		{
			public WebGLTextures(object gl, object extensions, object state, object properties, object capabilities, Function paramThreeToGL, object info) { }
			public virtual void setTexture2D(object texture, double slot) { }
			public virtual void setTextureCube(object texture, double slot) { }
			public virtual void setTextureCubeDynamic(object texture, double slot) { }
			public virtual void setupRenderTarget(object renderTarget) { }
			public virtual void updateRenderTargetMipmap(object renderTarget) { }
			public WebGLTextures() { }
		}
		public partial class WebGLUniforms
		{
			public virtual WebGLRenderer renderer { get; set; }
			public WebGLUniforms(object gl, WebGLProgram program, WebGLRenderer renderer) { }
			public virtual void setValue(object gl, object value, object renderer) { }
			public virtual void set(object gl, object @object, string name) { }
			public virtual void setOptional(object gl, object @object, string name) { }
			public virtual void upload(object gl, object seq, object[] values, object renderer) { }
			public virtual object[] seqWithValue(object seq, object[] values) => default(object[]);
			public virtual object[] splitDynamic(object seq, object[] values) => default(object[]);
			public virtual object[] evalDynamic(object seq, object[] values, object @object, object camera) => default(object[]);
			public WebGLUniforms() { }
		}
		public partial class WebGLProperties
		{
			public WebGLProperties() { }
			public virtual object get(object @object) => default(object);
			public virtual void delete(object @object) { }
			public virtual void clear() { }
		}
		public partial class WebGLShader
		{
			public WebGLShader(object gl, string type, string @string) { }
			public WebGLShader() { }
		}
		public partial class WebGLShadowMap
		{
			public virtual bool enabled { get; set; }
			public virtual bool autoUpdate { get; set; }
			public virtual bool needsUpdate { get; set; }
			public virtual ShadowMapType type { get; set; }
			public virtual object cullFace { get; set; }
			public WebGLShadowMap(Renderer _renderer, object[] _lights, object[] _objects, object capabilities) { }
			public virtual void render(Scene scene, Camera camera) { }
			public WebGLShadowMap() { }
		}
		public partial class WebGLState
		{
			public partial interface WebGLState_Type_0
			{
				WebGLColorBuffer color { get; set; }
				WebGLDepthBuffer depth { get; set; }
				WebGLStencilBuffer stencil { get; set; }
			}
			public virtual WebGLState_Type_0 buffers { get; set; }
			public WebGLState(object gl, object extensions, Function paramThreeToGL) { }
			public virtual void init() { }
			public virtual void initAttributes() { }
			public virtual void enableAttribute(string attribute) { }
			public virtual void enableAttributeAndDivisor(string attribute, object meshPerAttribute, object extension) { }
			public virtual void disableUnusedAttributes() { }
			public virtual void enable(string id) { }
			public virtual void disable(string id) { }
			public virtual object[] getCompressedTextureFormats() => default(object[]);
			public virtual void setBlending(double blending, double blendEquation, double blendSrc, double blendDst, double blendEquationAlpha, double blendSrcAlpha, double blendDstAlpha, bool premultiplyAlpha) { }
			public virtual void setColorWrite(double colorWrite) { }
			public virtual void setDepthTest(double depthTest) { }
			public virtual void setDepthWrite(double depthWrite) { }
			public virtual void setDepthFunc(Function depthFunc) { }
			public virtual void setStencilTest(bool stencilTest) { }
			public virtual void setStencilWrite(object stencilWrite) { }
			public virtual void setStencilFunc(Function stencilFunc, object stencilRef, double stencilMask) { }
			public virtual void setStencilOp(object stencilFail, object stencilZFail, object stencilZPass) { }
			public virtual void setFlipSided(double flipSided) { }
			public virtual void setCullFace(CullFace cullFace) { }
			public virtual void setLineWidth(double width) { }
			public virtual void setPolygonOffset(double polygonoffset, double factor, double units) { }
			public virtual void setScissorTest(bool scissorTest) { }
			public virtual bool getScissorTest() => default(bool);
			public virtual void activeTexture(object webglSlot) { }
			public virtual void bindTexture(object webglType, object webglTexture) { }
			public virtual void compressedTexImage2D() { }
			public virtual void texImage2D() { }
			public virtual void clearColor(double r, double g, double b, double a) { }
			public virtual void clearDepth(double depth) { }
			public virtual void clearStencil(object stencil) { }
			public virtual void scissor(object scissor) { }
			public virtual void viewport(object viewport) { }
			public virtual void reset() { }
			public WebGLState() { }
		}
		public partial class WebGLColorBuffer
		{
			public WebGLColorBuffer(object gl, object state) { }
			public virtual void setMask(double colorMask) { }
			public virtual void setLocked(bool @lock) { }
			public virtual void setClear(double r, double g, double b, double a) { }
			public virtual void reset() { }
			public WebGLColorBuffer() { }
		}
		public partial class WebGLDepthBuffer
		{
			public WebGLDepthBuffer(object gl, object state) { }
			public virtual void setTest(bool depthTest) { }
			public virtual void setMask(double depthMask) { }
			public virtual void setFunc(double depthFunc) { }
			public virtual void setLocked(bool @lock) { }
			public virtual void setClear(object depth) { }
			public virtual void reset() { }
			public WebGLDepthBuffer() { }
		}
		public partial class WebGLStencilBuffer
		{
			public WebGLStencilBuffer(object gl, object state) { }
			public virtual void setTest(bool stencilTest) { }
			public virtual void setMask(double stencilMask) { }
			public virtual void setFunc(double stencilFunc, object stencilRef, double stencilMask) { }
			public virtual void setOp(object stencilFail, object stencilZFail, object stencilZPass) { }
			public virtual void setLocked(bool @lock) { }
			public virtual void setClear(object stencil) { }
			public virtual void reset() { }
			public WebGLStencilBuffer() { }
		}
		public partial class SpritePlugin
		{
			public SpritePlugin(WebGLRenderer renderer, object[] sprites) { }
			public virtual void render(Scene scene, Camera camera, double viewportWidth, double viewportHeight) { }
			public SpritePlugin() { }
		}
		public partial class Scene : Object3D
		{
			public class Scene_Type_0 : Enumerated
			{
				public static string Scene = "Scene";
				public static implicit operator Scene_Type_0(string value) { return new Scene_Type_0(value); }
				public Scene_Type_0(object value) { Value = value; }
			}
			public virtual Scene_Type_0 type { get; set; }
			public virtual Union<IFog, object> fog { get; set; }
			public virtual Union<Material, object> overrideMaterial { get; set; }
			public virtual bool autoUpdate { get; set; }
			public virtual Union<object, Color, Texture> background { get; set; }
			public Scene() { }
			public virtual Scene copy(Scene source, bool recursive) => default(Scene);
			public virtual object toJSON(object meta) => default(object);
		}
		public partial interface IFog
		{
			string name { get; set; }
			Color color { get; set; }
			IFog clone();
			object toJSON();
		}
		public partial class Fog : IFog
		{
			public virtual string name { get; set; }
			public virtual Color color { get; set; }
			public virtual double near { get; set; }
			public virtual double far { get; set; }
			public Fog(double hex, double near, double far) { }
			public virtual Fog clone() => default(Fog);
			public virtual object toJSON() => default(object);
			public Fog() { }
			IFog THREE.IFog.clone() => default(IFog);
			object THREE.IFog.toJSON() => default(object);
		}
		public partial class FogExp2 : IFog
		{
			public virtual string name { get; set; }
			public virtual Color color { get; set; }
			public virtual double density { get; set; }
			public FogExp2(Union<double, string> hex, double density) { }
			public virtual FogExp2 clone() => default(FogExp2);
			public virtual object toJSON() => default(object);
			public FogExp2() { }
			IFog THREE.IFog.clone() => default(IFog);
			object THREE.IFog.toJSON() => default(object);
		}
		public virtual double TextureIdCount { get; set; }
		public partial class Texture : EventDispatcher
		{
			public virtual double id { get; set; }
			public virtual string uuid { get; set; }
			public virtual string name { get; set; }
			public virtual string sourceFile { get; set; }
			public virtual object image { get; set; }
			public virtual ImageData[] mipmaps { get; set; }
			public virtual Mapping mapping { get; set; }
			public virtual Wrapping wrapS { get; set; }
			public virtual Wrapping wrapT { get; set; }
			public virtual TextureFilter magFilter { get; set; }
			public virtual TextureFilter minFilter { get; set; }
			public virtual double anisotropy { get; set; }
			public virtual PixelFormat format { get; set; }
			public virtual TextureDataType type { get; set; }
			public virtual Vector2 offset { get; set; }
			public virtual Vector2 repeat { get; set; }
			public virtual Vector2 center { get; set; }
			public virtual double rotation { get; set; }
			public virtual bool generateMipmaps { get; set; }
			public virtual bool premultiplyAlpha { get; set; }
			public virtual bool flipY { get; set; }
			public virtual double unpackAlignment { get; set; }
			public virtual TextureEncoding encoding { get; set; }
			public virtual double version { get; set; }
			public virtual bool needsUpdate { get; set; }
			public virtual Action onUpdate { get; set; }
			public virtual object DEFAULT_IMAGE { get; set; }
			public virtual object DEFAULT_MAPPING { get; set; }
			public Texture(Union<HTMLImageElement, HTMLCanvasElement, HTMLVideoElement> image, Mapping mapping, Wrapping wrapS, Wrapping wrapT, TextureFilter magFilter, TextureFilter minFilter, PixelFormat format, TextureDataType type, double anisotropy, TextureEncoding encoding) { }
			public virtual Texture clone() => default(Texture);
			public virtual Texture copy(Texture source) => default(Texture);
			public virtual object toJSON(object meta) => default(object);
			public virtual void dispose() { }
			public virtual void transformUv(Vector uv) { }
			public Texture() { }
		}
		public partial class DepthTexture : Texture
		{
			public partial interface DepthTexture_Type_0
			{
				double width { get; set; }
				double height { get; set; }
			}
			public virtual DepthTexture_Type_0 image { get; set; }
			public DepthTexture(double width, double heighht, TextureDataType type, Mapping mapping, Wrapping wrapS, Wrapping wrapT, TextureFilter magFilter, TextureFilter minFilter, double anisotropy) { }
			public DepthTexture() { }
		}
		public partial class CanvasTexture : Texture
		{
			public CanvasTexture(Union<HTMLImageElement, HTMLCanvasElement, HTMLVideoElement> canvas, Mapping mapping, Wrapping wrapS, Wrapping wrapT, TextureFilter magFilter, TextureFilter minFilter, PixelFormat format, TextureDataType type, double anisotropy) { }
			public CanvasTexture() { }
		}
		public partial class CubeTexture : Texture
		{
			public virtual object images { get; set; }
			public CubeTexture(object[] images, Mapping mapping, Wrapping wrapS, Wrapping wrapT, TextureFilter magFilter, TextureFilter minFilter, PixelFormat format, TextureDataType type, double anisotropy, TextureEncoding encoding) { }
			public CubeTexture() { }
		}
		public partial class CompressedTexture : Texture
		{
			public partial interface CompressedTexture_Type_0
			{
				double width { get; set; }
				double height { get; set; }
			}
			public virtual CompressedTexture_Type_0 image { get; set; }
			public CompressedTexture(ImageData[] mipmaps, double width, double height, PixelFormat format, TextureDataType type, Mapping mapping, Wrapping wrapS, Wrapping wrapT, TextureFilter magFilter, TextureFilter minFilter, double anisotropy, TextureEncoding encoding) { }
			public CompressedTexture() { }
		}
		public partial class DataTexture : Texture
		{
			public virtual ImageData image { get; set; }
			public DataTexture(Union<ArrayBuffer, TypedArray> data, double width, double height, PixelFormat format, TextureDataType type, Mapping mapping, Wrapping wrapS, Wrapping wrapT, TextureFilter magFilter, TextureFilter minFilter, double anisotropy, TextureEncoding encoding) { }
			public DataTexture() { }
		}
		public partial class VideoTexture : Texture
		{
			public VideoTexture(HTMLVideoElement video, Mapping mapping, Wrapping wrapS, Wrapping wrapT, TextureFilter magFilter, TextureFilter minFilter, PixelFormat format, TextureDataType type, double anisotropy) { }
			public VideoTexture() { }
		}
		public partial class ImageUtils
		{
			public virtual string crossOrigin { get; set; }
			public virtual Texture loadTexture(string url, Mapping mapping, Action<Texture> onLoad, Action<string> onError) => default(Texture);
			public virtual Texture loadTextureCube(string[] array, Mapping mapping, Action<Texture> onLoad, Action<string> onError) => default(Texture);
			public ImageUtils() { }
		}
		public partial class SceneUtils
		{
			public virtual Object3D createMultiMaterialObject(Geometry geometry, Material[] materials) => default(Object3D);
			public virtual void detach(Object3D child, Object3D parent, Scene scene) { }
			public virtual void attach(Object3D child, Scene scene, Object3D parent) { }
			public SceneUtils() { }
		}
		public partial interface Vec2
		{
			double x { get; set; }
			double y { get; set; }
		}
		public partial class ShapeUtils
		{
			public virtual double area(Vec2[] contour) => default(double);
			public virtual double[] triangulate(Vec2[] contour, bool indices) => default(double[]);
			public virtual double[][] triangulateShape(Vec2[] contour, Vec2[] holes) => default(double[][]);
			public virtual bool isClockWise(Vec2[] pts) => default(bool);
			public ShapeUtils() { }
		}
		public partial class Audio : Object3D
		{
			public class Audio_Type_0 : Enumerated
			{
				public static string Audio = "Audio";
				public static implicit operator Audio_Type_0(string value) { return new Audio_Type_0(value); }
				public Audio_Type_0(object value) { Value = value; }
			}
			public virtual Audio_Type_0 type { get; set; }
			public virtual AudioContext context { get; set; }
			public virtual GainNode gain { get; set; }
			public virtual bool autoplay { get; set; }
			public virtual Union<object, Audio> buffer { get; set; }
			public virtual bool loop { get; set; }
			public virtual double startTime { get; set; }
			public virtual double offset { get; set; }
			public virtual double playbackRate { get; set; }
			public virtual bool isPlaying { get; set; }
			public virtual bool hasPlaybackControl { get; set; }
			public virtual string sourceType { get; set; }
			public virtual AudioBufferSourceNode source { get; set; }
			public virtual object[] filters { get; set; }
			public Audio(AudioListener listener) { }
			public virtual GainNode getOutput() => default(GainNode);
			public virtual Audio setNodeSource(AudioBufferSourceNode audioNode) => default(Audio);
			public virtual Audio setMediaElementSource(MediaElementAudioSourceNode mediaElement) => default(Audio);
			public virtual Audio setBuffer(AudioBuffer audioBuffer) => default(Audio);
			public virtual Audio play() => default(Audio);
			public virtual void onEnded() { }
			public virtual Audio pause() => default(Audio);
			public virtual Audio stop() => default(Audio);
			public virtual Audio connect() => default(Audio);
			public virtual Audio disconnect() => default(Audio);
			public virtual object[] getFilters() => default(object[]);
			public virtual Audio setFilter(object[] value) => default(Audio);
			public virtual object getFilter() => default(object);
			public virtual Audio setFilter(object filter) => default(Audio);
			public virtual Audio setPlaybackRate(double value) => default(Audio);
			public virtual double getPlaybackRate() => default(double);
			public virtual bool getLoop() => default(bool);
			public virtual void setLoop(bool value) { }
			public virtual double getVolume() => default(double);
			public virtual Audio setVolume(double value) => default(Audio);
			public virtual Audio load(string file) => default(Audio);
			public Audio() { }
		}
		public partial class AudioAnalyser
		{
			public virtual object analyser { get; set; }
			public virtual Uint8Array data { get; set; }
			public AudioAnalyser(object audio, double fftSize) { }
			public virtual Uint8Array getFrequencyData() => default(Uint8Array);
			public virtual double getAverageFrequency() => default(double);
			public virtual object getData(object file) => default(object);
			public AudioAnalyser() { }
		}
		public virtual AudioContext AudioContext { get; set; }
		public partial class AudioBuffer
		{
			public virtual object context { get; set; }
			public virtual bool ready { get; set; }
			public virtual Function[] readyCallbacks { get; set; }
			public AudioBuffer(object context) { }
			public virtual AudioBuffer load(string file) => default(AudioBuffer);
			public virtual void onReady(Function callback) { }
			public AudioBuffer() { }
		}
		public partial class PositionalAudio : Audio
		{
			public virtual PannerNode panner { get; set; }
			public PositionalAudio(AudioListener listener) { }
			public virtual void setRefDistance(double value) { }
			public virtual double getRefDistance() => default(double);
			public virtual void setRolloffFactor(double value) { }
			public virtual double getRolloffFactor() => default(double);
			public virtual void setDistanceModel(double value) { }
			public virtual double getDistanceModel() => default(double);
			public virtual void setMaxDistance(double value) { }
			public virtual double getMaxDistance() => default(double);
			public PositionalAudio() { }
		}
		public partial class AudioListener : Object3D
		{
			public class AudioListener_Type_0 : Enumerated
			{
				public static string AudioListener = "AudioListener";
				public static implicit operator AudioListener_Type_0(string value) { return new AudioListener_Type_0(value); }
				public AudioListener_Type_0(object value) { Value = value; }
			}
			public virtual AudioListener_Type_0 type { get; set; }
			public virtual AudioContext context { get; set; }
			public virtual GainNode gain { get; set; }
			public virtual Union<object, object> filter { get; set; }
			public AudioListener() { }
			public virtual GainNode getInput() => default(GainNode);
			public virtual void removeFilter() { }
			public virtual void setFilter(object value) { }
			public virtual object getFilter() => default(object);
			public virtual void setMasterVolume(double value) { }
			public virtual double getMasterVolume() => default(double);
			public virtual void updateMatrixWorld(bool force) { }
		}
		public partial class Curve<T>
		{
			public virtual double arcLengthDivisions { get; set; }
			public virtual T getPoint(double t, T optionalTarget) => default(T);
			public virtual T getPointAt(double u, T optionalTarget) => default(T);
			public virtual T[] getPoints(double divisions) => default(T[]);
			public virtual T[] getSpacedPoints(double divisions) => default(T[]);
			public virtual double getLength() => default(double);
			public virtual double[] getLengths(double divisions) => default(double[]);
			public virtual void updateArcLengths() { }
			public virtual double getUtoTmapping(double u, double distance) => default(double);
			public virtual T getTangent(double t) => default(T);
			public virtual T getTangentAt(double u) => default(T);
			public virtual Function create(Function constructorFunc, Function getPointFunc) => default(Function);
			public Curve() { }
		}
		public partial class CurvePath<T> : Curve<T>
		{
			public virtual Curve<T>[] curves { get; set; }
			public virtual bool autoClose { get; set; }
			public CurvePath() { }
			public virtual void add(Curve<T> curve) { }
			public virtual bool checkConnection() => default(bool);
			public virtual void closePath() { }
			public virtual T getPoint(double t) => default(T);
			public virtual double getLength() => default(double);
			public virtual void updateArcLengths() { }
			public virtual double[] getCurveLengths() => default(double[]);
			public virtual T[] getSpacedPoints(double divisions) => default(T[]);
			public virtual T[] getPoints(double divisions) => default(T[]);
			public virtual Geometry createPointsGeometry(double divisions) => default(Geometry);
			public virtual Geometry createSpacedPointsGeometry(double divisions) => default(Geometry);
			public virtual Geometry createGeometry(T[] points) => default(Geometry);
		}
		public enum PathActions
		{
			MOVE_TO,
			LINE_TO,
			QUADRATIC_CURVE_TO,
			BEZIER_CURVE_TO,
			CSPLINE_THRU,
			ARC,
			ELLIPSE
		}
		public partial interface PathAction
		{
			PathActions action { get; set; }
			object args { get; set; }
		}
		public partial class Path : CurvePath<Vector2>
		{
			public virtual Vector2 currentPoint { get; set; }
			public Path(Vector2[] points) { }
			public virtual void fromPoints(Vector2[] vectors) { }
			public virtual void setFromPoints(Vector2[] vectors) { }
			public virtual void moveTo(double x, double y) { }
			public virtual void lineTo(double x, double y) { }
			public virtual void quadraticCurveTo(double aCPx, double aCPy, double aX, double aY) { }
			public virtual void bezierCurveTo(double aCP1x, double aCP1y, double aCP2x, double aCP2y, double aX, double aY) { }
			public virtual void splineThru(Vector2[] pts) { }
			public virtual void arc(double aX, double aY, double aRadius, double aStartAngle, double aEndAngle, bool aClockwise) { }
			public virtual void absarc(double aX, double aY, double aRadius, double aStartAngle, double aEndAngle, bool aClockwise) { }
			public virtual void ellipse(double aX, double aY, double xRadius, double yRadius, double aStartAngle, double aEndAngle, bool aClockwise, double aRotation) { }
			public virtual void absellipse(double aX, double aY, double xRadius, double yRadius, double aStartAngle, double aEndAngle, bool aClockwise, double aRotation) { }
			public Path() { }
		}
		public partial class ShapePath
		{
			public virtual object[] subPaths { get; set; }
			public virtual object currentPath { get; set; }
			public ShapePath() { }
			public virtual void moveTo(double x, double y) { }
			public virtual void lineTo(double x, double y) { }
			public virtual void quadraticCurveTo(double aCPx, double aCPy, double aX, double aY) { }
			public virtual void bezierCurveTo(double aCP1x, double aCP1y, double aCP2x, double aCP2y, double aX, double aY) { }
			public virtual void splineThru(Vector2[] pts) { }
			public virtual Shape[] toShapes(bool isCCW, object noHoles) => default(Shape[]);
		}
		public partial class Shape : Path
		{
			public partial interface Shape_Type_0
			{
				Vector2[] shape { get; set; }
				Vector2[][] holes { get; set; }
			}
			public virtual Path[] holes { get; set; }
			public Shape(Vector2[] points) { }
			public virtual ExtrudeGeometry extrude(object options) => default(ExtrudeGeometry);
			public virtual ShapeGeometry makeGeometry(object options) => default(ShapeGeometry);
			public virtual Vector2[][] getPointsHoles(double divisions) => default(Vector2[][]);
			public virtual Shape_Type_0 extractAllPoints(double divisions) => default(Shape_Type_0);
			public virtual Vector2[] extractPoints(double divisions) => default(Vector2[]);
			public Shape() { }
		}
		public partial class CurveUtils
		{
			public virtual double tangentQuadraticBezier(double t, double p0, double p1, double p2) => default(double);
			public virtual double tangentCubicBezier(double t, double p0, double p1, double p2, double p3) => default(double);
			public virtual double tangentSpline(double t, double p0, double p1, double p2, double p3) => default(double);
			public virtual double interpolate(double p0, double p1, double p2, double p3, double t) => default(double);
			public CurveUtils() { }
		}
		public partial class CatmullRomCurve3 : Curve<Vector3>
		{
			public virtual Vector3[] points { get; set; }
			public CatmullRomCurve3(Vector3[] points, bool closed, string curveType, double tension) { }
			public virtual Vector3 getPoint(double t) => default(Vector3);
			public CatmullRomCurve3() { }
		}
		public partial class CubicBezierCurve : Curve<Vector2>
		{
			public virtual Vector2 v0 { get; set; }
			public virtual Vector2 v1 { get; set; }
			public virtual Vector2 v2 { get; set; }
			public virtual Vector2 v3 { get; set; }
			public CubicBezierCurve(Vector2 v0, Vector2 v1, Vector2 v2, Vector2 v3) { }
			public CubicBezierCurve() { }
		}
		public partial class CubicBezierCurve3 : Curve<Vector3>
		{
			public virtual Vector3 v0 { get; set; }
			public virtual Vector3 v1 { get; set; }
			public virtual Vector3 v2 { get; set; }
			public virtual Vector3 v3 { get; set; }
			public CubicBezierCurve3(Vector3 v0, Vector3 v1, Vector3 v2, Vector3 v3) { }
			public virtual Vector3 getPoint(double t) => default(Vector3);
			public CubicBezierCurve3() { }
		}
		public partial class EllipseCurve : Curve<Vector2>
		{
			public virtual double aX { get; set; }
			public virtual double aY { get; set; }
			public virtual double xRadius { get; set; }
			public virtual double yRadius { get; set; }
			public virtual double aStartAngle { get; set; }
			public virtual double aEndAngle { get; set; }
			public virtual bool aClockwise { get; set; }
			public virtual double aRotation { get; set; }
			public EllipseCurve(double aX, double aY, double xRadius, double yRadius, double aStartAngle, double aEndAngle, bool aClockwise, double aRotation) { }
			public EllipseCurve() { }
		}
		public partial class ArcCurve : EllipseCurve
		{
			public ArcCurve(double aX, double aY, double aRadius, double aStartAngle, double aEndAngle, bool aClockwise) { }
			public ArcCurve() { }
		}
		public partial class LineCurve : Curve<Vector2>
		{
			public virtual Vector2 v1 { get; set; }
			public virtual Vector2 v2 { get; set; }
			public LineCurve(Vector2 v1, Vector2 v2) { }
			public LineCurve() { }
		}
		public partial class LineCurve3 : Curve<Vector3>
		{
			public virtual Vector3 v1 { get; set; }
			public virtual Vector3 v2 { get; set; }
			public LineCurve3(Vector3 v1, Vector3 v2) { }
			public virtual Vector3 getPoint(double t) => default(Vector3);
			public LineCurve3() { }
		}
		public partial class QuadraticBezierCurve : Curve<Vector2>
		{
			public virtual Vector2 v0 { get; set; }
			public virtual Vector2 v1 { get; set; }
			public virtual Vector2 v2 { get; set; }
			public QuadraticBezierCurve(Vector2 v0, Vector2 v1, Vector2 v2) { }
			public QuadraticBezierCurve() { }
		}
		public partial class QuadraticBezierCurve3 : Curve<Vector3>
		{
			public virtual Vector3 v0 { get; set; }
			public virtual Vector3 v1 { get; set; }
			public virtual Vector3 v2 { get; set; }
			public QuadraticBezierCurve3(Vector3 v0, Vector3 v1, Vector3 v2) { }
			public virtual Vector3 getPoint(double t) => default(Vector3);
			public QuadraticBezierCurve3() { }
		}
		public partial class SplineCurve : Curve<Vector2>
		{
			public virtual Vector2[] points { get; set; }
			public SplineCurve(Vector2[] points) { }
			public SplineCurve() { }
		}
		public partial class BoxBufferGeometry : BufferGeometry
		{
			public partial interface BoxBufferGeometry_Type_0
			{
				double width { get; set; }
				double height { get; set; }
				double depth { get; set; }
				double widthSegments { get; set; }
				double heightSegments { get; set; }
				double depthSegments { get; set; }
			}
			public virtual BoxBufferGeometry_Type_0 parameters { get; set; }
			public BoxBufferGeometry(double width, double height, double depth, double widthSegments, double heightSegments, double depthSegments) { }
			public BoxBufferGeometry() { }
		}
		public partial class BoxGeometry : Geometry
		{
			public partial interface BoxGeometry_Type_0
			{
				double width { get; set; }
				double height { get; set; }
				double depth { get; set; }
				double widthSegments { get; set; }
				double heightSegments { get; set; }
				double depthSegments { get; set; }
			}
			public virtual BoxGeometry_Type_0 parameters { get; set; }
			public BoxGeometry(double width, double height, double depth, double widthSegments, double heightSegments, double depthSegments) { }
			public BoxGeometry() { }
		}
		public partial class CubeGeometry : BoxGeometry
		{
			public CubeGeometry() { }
		}
		public partial class CircleBufferGeometry : BufferGeometry
		{
			public partial interface CircleBufferGeometry_Type_0
			{
				double radius { get; set; }
				double segments { get; set; }
				double thetaStart { get; set; }
				double thetaLength { get; set; }
			}
			public virtual CircleBufferGeometry_Type_0 parameters { get; set; }
			public CircleBufferGeometry(double radius, double segments, double thetaStart, double thetaLength) { }
			public CircleBufferGeometry() { }
		}
		public partial class CircleGeometry : Geometry
		{
			public partial interface CircleGeometry_Type_0
			{
				double radius { get; set; }
				double segments { get; set; }
				double thetaStart { get; set; }
				double thetaLength { get; set; }
			}
			public virtual CircleGeometry_Type_0 parameters { get; set; }
			public CircleGeometry(double radius, double segments, double thetaStart, double thetaLength) { }
			public CircleGeometry() { }
		}
		public partial class CylinderBufferGeometry : BufferGeometry
		{
			public partial interface CylinderBufferGeometry_Type_0
			{
				double radiusTop { get; set; }
				double radiusBottom { get; set; }
				double height { get; set; }
				double radialSegments { get; set; }
				double heightSegments { get; set; }
				bool openEnded { get; set; }
				double thetaStart { get; set; }
				double thetaLength { get; set; }
			}
			public virtual CylinderBufferGeometry_Type_0 parameters { get; set; }
			public CylinderBufferGeometry(double radiusTop, double radiusBottom, double height, double radialSegments, double heightSegments, bool openEnded, double thetaStart, double thetaLength) { }
			public CylinderBufferGeometry() { }
		}
		public partial class CylinderGeometry : Geometry
		{
			public partial interface CylinderGeometry_Type_0
			{
				double radiusTop { get; set; }
				double radiusBottom { get; set; }
				double height { get; set; }
				double radialSegments { get; set; }
				double heightSegments { get; set; }
				bool openEnded { get; set; }
				double thetaStart { get; set; }
				double thetaLength { get; set; }
			}
			public virtual CylinderGeometry_Type_0 parameters { get; set; }
			public CylinderGeometry(double radiusTop, double radiusBottom, double height, double radiusSegments, double heightSegments, bool openEnded, double thetaStart, double thetaLength) { }
			public CylinderGeometry() { }
		}
		public partial class ConeBufferGeometry : BufferGeometry
		{
			public ConeBufferGeometry(double radius, double height, double radialSegment, double heightSegment, bool openEnded, double thetaStart, double thetaLength) { }
			public ConeBufferGeometry() { }
		}
		public partial class ConeGeometry : CylinderGeometry
		{
			public ConeGeometry(double radius, double height, double radialSegment, double heightSegment, bool openEnded, double thetaStart, double thetaLength) { }
			public ConeGeometry() { }
		}
		public partial class DodecahedronBufferGeometry : PolyhedronBufferGeometry
		{
			public DodecahedronBufferGeometry(double radius, double detail) { }
			public DodecahedronBufferGeometry() { }
		}
		public partial class DodecahedronGeometry : Geometry
		{
			public partial interface DodecahedronGeometry_Type_0
			{
				double radius { get; set; }
				double detail { get; set; }
			}
			public virtual DodecahedronGeometry_Type_0 parameters { get; set; }
			public DodecahedronGeometry(double radius, double detail) { }
			public DodecahedronGeometry() { }
		}
		public partial class EdgesGeometry : BufferGeometry
		{
			public EdgesGeometry(Union<BufferGeometry, Geometry> geometry, double thresholdAngle) { }
			public EdgesGeometry() { }
		}
		public partial interface ExtrudeGeometryOptions
		{
			double curveSegments { get; set; }
			double steps { get; set; }
			double depth { get; set; }
			bool bevelEnabled { get; set; }
			double bevelThickness { get; set; }
			double bevelSize { get; set; }
			double bevelSegments { get; set; }
			CurvePath<Vector3> extrudePath { get; set; }
			UVGenerator UVGenerator { get; set; }
		}
		public partial interface UVGenerator
		{
			Vector2[] generateTopUV(ExtrudeBufferGeometry geometry, double[] vertices, double indexA, double indexB, double indexC);
			Vector2[] generateSideWallUV(ExtrudeBufferGeometry geometry, double[] vertices, double indexA, double indexB, double indexC, double indexD);
		}
		public partial class ExtrudeGeometry : Geometry
		{
			public virtual UVGenerator WorldUVGenerator { get; set; }
			public ExtrudeGeometry(Union<Shape, Shape[]> shapes, ExtrudeGeometryOptions options) { }
			public virtual void addShapeList(Shape[] shapes, object options) { }
			public virtual void addShape(Shape shape, object options) { }
			public ExtrudeGeometry() { }
		}
		public partial class ExtrudeBufferGeometry : BufferGeometry
		{
			public virtual UVGenerator WorldUVGenerator { get; set; }
			public ExtrudeBufferGeometry(Union<Shape, Shape[]> shapes, ExtrudeGeometryOptions options) { }
			public virtual void addShapeList(Shape[] shapes, object options) { }
			public virtual void addShape(Shape shape, object options) { }
			public ExtrudeBufferGeometry() { }
		}
		public partial class IcosahedronBufferGeometry : PolyhedronBufferGeometry
		{
			public IcosahedronBufferGeometry(double radius, double detail) { }
			public IcosahedronBufferGeometry() { }
		}
		public partial class IcosahedronGeometry : PolyhedronGeometry
		{
			public IcosahedronGeometry(double radius, double detail) { }
			public IcosahedronGeometry() { }
		}
		public partial class LatheBufferGeometry : BufferGeometry
		{
			public partial interface LatheBufferGeometry_Type_0
			{
				Vector2[] points { get; set; }
				double segments { get; set; }
				double phiStart { get; set; }
				double phiLength { get; set; }
			}
			public virtual LatheBufferGeometry_Type_0 parameters { get; set; }
			public LatheBufferGeometry(Vector2[] points, double segments, double phiStart, double phiLength) { }
			public LatheBufferGeometry() { }
		}
		public partial class LatheGeometry : Geometry
		{
			public partial interface LatheGeometry_Type_0
			{
				Vector2[] points { get; set; }
				double segments { get; set; }
				double phiStart { get; set; }
				double phiLength { get; set; }
			}
			public virtual LatheGeometry_Type_0 parameters { get; set; }
			public LatheGeometry(Vector2[] points, double segments, double phiStart, double phiLength) { }
			public LatheGeometry() { }
		}
		public partial class OctahedronBufferGeometry : PolyhedronBufferGeometry
		{
			public OctahedronBufferGeometry(double radius, double detail) { }
			public OctahedronBufferGeometry() { }
		}
		public partial class OctahedronGeometry : PolyhedronGeometry
		{
			public OctahedronGeometry(double radius, double detail) { }
			public OctahedronGeometry() { }
		}
		public partial class ParametricBufferGeometry : BufferGeometry
		{
			public partial interface ParametricBufferGeometry_Type_0
			{
				Action<double, double, Vector3> func { get; set; }
				double slices { get; set; }
				double stacks { get; set; }
			}
			public virtual ParametricBufferGeometry_Type_0 parameters { get; set; }
			public ParametricBufferGeometry(Action<double, double, Vector3> func, double slices, double stacks) { }
			public ParametricBufferGeometry() { }
		}
		public partial class ParametricGeometry : Geometry
		{
			public partial interface ParametricGeometry_Type_0
			{
				Action<double, double, Vector3> func { get; set; }
				double slices { get; set; }
				double stacks { get; set; }
			}
			public virtual ParametricGeometry_Type_0 parameters { get; set; }
			public ParametricGeometry(Action<double, double, Vector3> func, double slices, double stacks) { }
			public ParametricGeometry() { }
		}
		public partial class PlaneBufferGeometry : BufferGeometry
		{
			public partial interface PlaneBufferGeometry_Type_0
			{
				double width { get; set; }
				double height { get; set; }
				double widthSegments { get; set; }
				double heightSegments { get; set; }
			}
			public virtual PlaneBufferGeometry_Type_0 parameters { get; set; }
			public PlaneBufferGeometry(double width, double height, double widthSegments, double heightSegments) { }
			public PlaneBufferGeometry() { }
		}
		public partial class PlaneGeometry : Geometry
		{
			public partial interface PlaneGeometry_Type_0
			{
				double width { get; set; }
				double height { get; set; }
				double widthSegments { get; set; }
				double heightSegments { get; set; }
			}
			public virtual PlaneGeometry_Type_0 parameters { get; set; }
			public PlaneGeometry(double width, double height, double widthSegments, double heightSegments) { }
			public PlaneGeometry() { }
		}
		public partial class PolyhedronBufferGeometry : BufferGeometry
		{
			public partial interface PolyhedronBufferGeometry_Type_0
			{
				double[] vertices { get; set; }
				double[] indices { get; set; }
				double radius { get; set; }
				double detail { get; set; }
			}
			public virtual PolyhedronBufferGeometry_Type_0 parameters { get; set; }
			public PolyhedronBufferGeometry(double[] vertices, double[] indices, double radius, double detail) { }
			public PolyhedronBufferGeometry() { }
		}
		public partial class PolyhedronGeometry : Geometry
		{
			public partial interface PolyhedronGeometry_Type_0
			{
				double[] vertices { get; set; }
				double[] indices { get; set; }
				double radius { get; set; }
				double detail { get; set; }
			}
			public virtual PolyhedronGeometry_Type_0 parameters { get; set; }
			public virtual Sphere boundingSphere { get; set; }
			public PolyhedronGeometry(double[] vertices, double[] indices, double radius, double detail) { }
			public PolyhedronGeometry() { }
		}
		public partial class RingBufferGeometry : BufferGeometry
		{
			public partial interface RingBufferGeometry_Type_0
			{
				double innerRadius { get; set; }
				double outerRadius { get; set; }
				double thetaSegments { get; set; }
				double phiSegments { get; set; }
				double thetaStart { get; set; }
				double thetaLength { get; set; }
			}
			public virtual RingBufferGeometry_Type_0 parameters { get; set; }
			public RingBufferGeometry(double innerRadius, double outerRadius, double thetaSegments, double phiSegments, double thetaStart, double thetaLength) { }
			public RingBufferGeometry() { }
		}
		public partial class RingGeometry : Geometry
		{
			public partial interface RingGeometry_Type_0
			{
				double innerRadius { get; set; }
				double outerRadius { get; set; }
				double thetaSegments { get; set; }
				double phiSegments { get; set; }
				double thetaStart { get; set; }
				double thetaLength { get; set; }
			}
			public virtual RingGeometry_Type_0 parameters { get; set; }
			public RingGeometry(double innerRadius, double outerRadius, double thetaSegments, double phiSegments, double thetaStart, double thetaLength) { }
			public RingGeometry() { }
		}
		public partial class ShapeGeometry : Geometry
		{
			public ShapeGeometry(Union<Shape, Shape[]> shapes, double curveSegments) { }
			public virtual ShapeGeometry addShapeList(Shape[] shapes, object options) => default(ShapeGeometry);
			public virtual void addShape(Shape shape, object options) { }
			public ShapeGeometry() { }
		}
		public partial class ShapeBufferGeometry : BufferGeometry
		{
			public ShapeBufferGeometry(Union<Shape, Shape[]> shapes, double curveSegments) { }
			public ShapeBufferGeometry() { }
		}
		public partial class SphereBufferGeometry : BufferGeometry
		{
			public partial interface SphereBufferGeometry_Type_0
			{
				double radius { get; set; }
				double widthSegments { get; set; }
				double heightSegments { get; set; }
				double phiStart { get; set; }
				double phiLength { get; set; }
				double thetaStart { get; set; }
				double thetaLength { get; set; }
			}
			public virtual SphereBufferGeometry_Type_0 parameters { get; set; }
			public SphereBufferGeometry(double radius, double widthSegments, double heightSegments, double phiStart, double phiLength, double thetaStart, double thetaLength) { }
			public SphereBufferGeometry() { }
		}
		public partial class SphereGeometry : Geometry
		{
			public partial interface SphereGeometry_Type_0
			{
				double radius { get; set; }
				double widthSegments { get; set; }
				double heightSegments { get; set; }
				double phiStart { get; set; }
				double phiLength { get; set; }
				double thetaStart { get; set; }
				double thetaLength { get; set; }
			}
			public virtual SphereGeometry_Type_0 parameters { get; set; }
			public SphereGeometry(double radius, double widthSegments, double heightSegments, double phiStart, double phiLength, double thetaStart, double thetaLength) { }
			public SphereGeometry() { }
		}
		public partial class TetrahedronBufferGeometry : PolyhedronBufferGeometry
		{
			public TetrahedronBufferGeometry(double radius, double detail) { }
			public TetrahedronBufferGeometry() { }
		}
		public partial class TetrahedronGeometry : PolyhedronGeometry
		{
			public TetrahedronGeometry(double radius, double detail) { }
			public TetrahedronGeometry() { }
		}
		public partial interface TextGeometryParameters
		{
			Font font { get; set; }
			double size { get; set; }
			double height { get; set; }
			double curveSegments { get; set; }
			bool bevelEnabled { get; set; }
			double bevelThickness { get; set; }
			double bevelSize { get; set; }
			double bevelSegments { get; set; }
		}
		public partial class TextGeometry : ExtrudeGeometry
		{
			public partial interface TextGeometry_Type_0
			{
				Font font { get; set; }
				double size { get; set; }
				double height { get; set; }
				double curveSegments { get; set; }
				bool bevelEnabled { get; set; }
				double bevelThickness { get; set; }
				double bevelSize { get; set; }
				double bevelSegments { get; set; }
			}
			public virtual TextGeometry_Type_0 parameters { get; set; }
			public TextGeometry(string text, TextGeometryParameters parameters) { }
			public TextGeometry() { }
		}
		public partial class TextBufferGeometry : ExtrudeBufferGeometry
		{
			public partial interface TextBufferGeometry_Type_0
			{
				Font font { get; set; }
				double size { get; set; }
				double height { get; set; }
				double curveSegments { get; set; }
				bool bevelEnabled { get; set; }
				double bevelThickness { get; set; }
				double bevelSize { get; set; }
				double bevelSegments { get; set; }
			}
			public virtual TextBufferGeometry_Type_0 parameters { get; set; }
			public TextBufferGeometry(string text, TextGeometryParameters parameters) { }
			public TextBufferGeometry() { }
		}
		public partial class TorusBufferGeometry : BufferGeometry
		{
			public partial interface TorusBufferGeometry_Type_0
			{
				double radius { get; set; }
				double tube { get; set; }
				double radialSegments { get; set; }
				double tubularSegments { get; set; }
				double arc { get; set; }
			}
			public virtual TorusBufferGeometry_Type_0 parameters { get; set; }
			public TorusBufferGeometry(double radius, double tube, double radialSegments, double tubularSegments, double arc) { }
			public TorusBufferGeometry() { }
		}
		public partial class TorusGeometry : Geometry
		{
			public partial interface TorusGeometry_Type_0
			{
				double radius { get; set; }
				double tube { get; set; }
				double radialSegments { get; set; }
				double tubularSegments { get; set; }
				double arc { get; set; }
			}
			public virtual TorusGeometry_Type_0 parameters { get; set; }
			public TorusGeometry(double radius, double tube, double radialSegments, double tubularSegments, double arc) { }
			public TorusGeometry() { }
		}
		public partial class TorusKnotBufferGeometry : BufferGeometry
		{
			public partial interface TorusKnotBufferGeometry_Type_0
			{
				double radius { get; set; }
				double tube { get; set; }
				double tubularSegments { get; set; }
				double radialSegments { get; set; }
				double p { get; set; }
				double q { get; set; }
				double heightScale { get; set; }
			}
			public virtual TorusKnotBufferGeometry_Type_0 parameters { get; set; }
			public TorusKnotBufferGeometry(double radius, double tube, double tubularSegments, double radialSegments, double p, double q) { }
			public TorusKnotBufferGeometry() { }
		}
		public partial class TorusKnotGeometry : Geometry
		{
			public partial interface TorusKnotGeometry_Type_0
			{
				double radius { get; set; }
				double tube { get; set; }
				double tubularSegments { get; set; }
				double radialSegments { get; set; }
				double p { get; set; }
				double q { get; set; }
				double heightScale { get; set; }
			}
			public virtual TorusKnotGeometry_Type_0 parameters { get; set; }
			public TorusKnotGeometry(double radius, double tube, double tubularSegments, double radialSegments, double p, double q) { }
			public TorusKnotGeometry() { }
		}
		public partial class TubeGeometry : Geometry
		{
			public partial interface TubeGeometry_Type_0
			{
				Curve<Vector3> path { get; set; }
				double tubularSegments { get; set; }
				double radius { get; set; }
				double radialSegments { get; set; }
				bool closed { get; set; }
			}
			public virtual TubeGeometry_Type_0 parameters { get; set; }
			public virtual Vector3[] tangents { get; set; }
			public virtual Vector3[] normals { get; set; }
			public virtual Vector3[] binormals { get; set; }
			public TubeGeometry(Curve<Vector3> path, double tubularSegments, double radius, double radiusSegments, bool closed) { }
			public TubeGeometry() { }
		}
		public partial class TubeBufferGeometry : BufferGeometry
		{
			public partial interface TubeBufferGeometry_Type_0
			{
				Curve<Vector3> path { get; set; }
				double tubularSegments { get; set; }
				double radius { get; set; }
				double radialSegments { get; set; }
				bool closed { get; set; }
			}
			public virtual TubeBufferGeometry_Type_0 parameters { get; set; }
			public virtual Vector3[] tangents { get; set; }
			public virtual Vector3[] normals { get; set; }
			public virtual Vector3[] binormals { get; set; }
			public TubeBufferGeometry(Curve<Vector3> path, double tubularSegments, double radius, double radiusSegments, bool closed) { }
			public TubeBufferGeometry() { }
		}
		public partial class WireframeGeometry : BufferGeometry
		{
			public WireframeGeometry(Union<Geometry, BufferGeometry> geometry) { }
			public WireframeGeometry() { }
		}
		public partial class ArrowHelper : Object3D
		{
			public virtual Line line { get; set; }
			public virtual Mesh cone { get; set; }
			public ArrowHelper(Vector3 dir, Vector3 origin, double length, double hex, double headLength, double headWidth) { }
			public virtual void setDirection(Vector3 dir) { }
			public virtual void setLength(double length, double headLength, double headWidth) { }
			public virtual void setColor(Color color) { }
			public ArrowHelper() { }
		}
		public partial class AxesHelper : LineSegments
		{
			public AxesHelper(double size) { }
			public AxesHelper() { }
		}
		public partial class BoundingBoxHelper : Mesh
		{
			public virtual Object3D @object { get; set; }
			public virtual Box3 box { get; set; }
			public BoundingBoxHelper(Object3D @object, double hex) { }
			public virtual void update() { }
			public BoundingBoxHelper() { }
		}
		public partial class BoxHelper : LineSegments
		{
			public BoxHelper(Object3D @object, Color color) { }
			public virtual void update(Object3D @object) { }
			public BoxHelper() { }
		}
		public partial class CameraHelper : LineSegments
		{
			public partial interface CameraHelper_Type_0
			{
				double[] this[string id] { get; set; }
			}
			public virtual Camera camera { get; set; }
			public virtual CameraHelper_Type_0 pointMap { get; set; }
			public CameraHelper(Camera camera) { }
			public virtual void update() { }
			public CameraHelper() { }
		}
		public partial class DirectionalLightHelper : Object3D
		{
			public virtual DirectionalLight light { get; set; }
			public virtual Line lightPlane { get; set; }
			public virtual Line targetPlane { get; set; }
			public virtual Union<Color, string, double, undefined> color { get; set; }
			public virtual Matrix4 matrix { get; set; }
			public virtual bool matrixAutoUpdate { get; set; }
			public DirectionalLightHelper(DirectionalLight light, double size, Union<Color, string, double> color) { }
			public virtual void dispose() { }
			public virtual void update() { }
			public DirectionalLightHelper() { }
		}
		public partial class EdgesHelper : LineSegments
		{
			public EdgesHelper(Object3D @object, double hex, double thresholdAngle) { }
			public EdgesHelper() { }
		}
		public partial class FaceNormalsHelper : LineSegments
		{
			public virtual Object3D @object { get; set; }
			public virtual double size { get; set; }
			public FaceNormalsHelper(Object3D @object, double size, double hex, double linewidth) { }
			public virtual void update(Object3D @object) { }
			public FaceNormalsHelper() { }
		}
		public partial class GridHelper : LineSegments
		{
			public GridHelper(double size, double divisions, Union<Color, double> color1, Union<Color, double> color2) { }
			public virtual void setColors(Union<Color, double> color1, Union<Color, double> color2) { }
			public GridHelper() { }
		}
		public partial class HemisphereLightHelper : Object3D
		{
			public virtual HemisphereLight light { get; set; }
			public virtual Matrix4 matrix { get; set; }
			public virtual bool matrixAutoUpdate { get; set; }
			public virtual MeshBasicMaterial material { get; set; }
			public virtual Union<Color, string, double, undefined> color { get; set; }
			public HemisphereLightHelper(HemisphereLight light, double size, Union<Color, double, string> color) { }
			public virtual void dispose() { }
			public virtual void update() { }
			public HemisphereLightHelper() { }
		}
		public partial class PointLightHelper : Object3D
		{
			public virtual PointLight light { get; set; }
			public virtual Union<Color, string, double, undefined> color { get; set; }
			public virtual Matrix4 matrix { get; set; }
			public virtual bool matrixAutoUpdate { get; set; }
			public PointLightHelper(PointLight light, double sphereSize, Union<Color, string, double> color) { }
			public virtual void dispose() { }
			public virtual void update() { }
			public PointLightHelper() { }
		}
		public partial class SkeletonHelper : LineSegments
		{
			public virtual Bone[] bones { get; set; }
			public virtual Object3D root { get; set; }
			public SkeletonHelper(Object3D bone) { }
			public virtual Bone[] getBoneList(Object3D @object) => default(Bone[]);
			public virtual void update() { }
			public SkeletonHelper() { }
		}
		public partial class SpotLightHelper : Object3D
		{
			public virtual Light light { get; set; }
			public virtual Matrix4 matrix { get; set; }
			public virtual bool matrixAutoUpdate { get; set; }
			public virtual Union<Color, string, double, undefined> color { get; set; }
			public SpotLightHelper(Light light, Union<Color, string, double> color) { }
			public virtual void dispose() { }
			public virtual void update() { }
			public SpotLightHelper() { }
		}
		public partial class VertexNormalsHelper : LineSegments
		{
			public virtual Object3D @object { get; set; }
			public virtual double size { get; set; }
			public VertexNormalsHelper(Object3D @object, double size, double hex, double linewidth) { }
			public virtual void update(Object3D @object) { }
			public VertexNormalsHelper() { }
		}
		public partial class PlaneHelper : LineSegments
		{
			public virtual Plane plane { get; set; }
			public virtual double size { get; set; }
			public PlaneHelper(Plane plane, double size, double hex) { }
			public virtual void updateMatrixWorld(bool force) { }
			public PlaneHelper() { }
		}
		public partial class WireframeHelper : LineSegments
		{
			public WireframeHelper(Object3D @object, double hex) { }
			public WireframeHelper() { }
		}
		public partial class ImmediateRenderObject : Object3D
		{
			public virtual Material material { get; set; }
			public ImmediateRenderObject(Material material) { }
			public virtual void render(Function renderCallback) { }
			public ImmediateRenderObject() { }
		}
		public partial interface MorphBlendMeshAnimation
		{
			double start { get; set; }
			double end { get; set; }
			double length { get; set; }
			double fps { get; set; }
			double duration { get; set; }
			double lastFrame { get; set; }
			double currentFrame { get; set; }
			bool active { get; set; }
			double time { get; set; }
			double direction { get; set; }
			double weight { get; set; }
			bool directionBackwards { get; set; }
			bool mirroredLoop { get; set; }
		}
		public partial class MorphBlendMesh : Mesh
		{
			public partial interface MorphBlendMesh_Type_0
			{
				MorphBlendMeshAnimation this[string name] { get; set; }
			}
			public virtual MorphBlendMesh_Type_0 animationsMap { get; set; }
			public virtual MorphBlendMeshAnimation[] animationsList { get; set; }
			public MorphBlendMesh(Geometry geometry, Material material) { }
			public virtual void createAnimation(string name, double start, double end, double fps) { }
			public virtual void autoCreateAnimations(double fps) { }
			public virtual void setAnimationDirectionForward(string name) { }
			public virtual void setAnimationDirectionBackward(string name) { }
			public virtual void setAnimationFPS(string name, double fps) { }
			public virtual void setAnimationDuration(string name, double duration) { }
			public virtual void setAnimationWeight(string name, double weight) { }
			public virtual void setAnimationTime(string name, double time) { }
			public virtual double getAnimationTime(string name) => default(double);
			public virtual double getAnimationDuration(string name) => default(double);
			public virtual void playAnimation(string name) { }
			public virtual void stopAnimation(string name) { }
			public virtual void update(double delta) { }
			public MorphBlendMesh() { }
		}
		public partial interface WebVRManager
		{
			bool enabled { get; set; }
			Union<VRDisplay, object> getDevice();
			void setDevice(Union<VRDisplay, object> device);
			void setPoseTarget(Union<Object3D, object> @object);
			Union<PerspectiveCamera, ArrayCamera> getCamera(PerspectiveCamera camera);
			void submitFrame();
			void dispose();
		}
		public partial class Curve : Curve<Vector>
		{
			public Curve() { }
		}
		public partial class CurvePath : CurvePath<Vector>
		{
			public CurvePath() { }
		}
	}
}