using System;
using Leopotam.EcsProto;
using Leopotam.EcsProto.QoL;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoProto{


class System308 : IProtoInitSystem, IProtoRunSystem{
 ProtoWorld _world = null;
 Aspect1 _aspect = null;
 ProtoIt _it;
 public void Init (IProtoSystems systems) {
  _world = systems.World ();
  _aspect = (Aspect1) _world.Aspect (typeof (Aspect1));
 _it = new ProtoIt (new [] {typeof(Component120),typeof(Component312),typeof(Component454),typeof(Component167) } );
  _it.Init (_world);
 }
 public void Run () {
  for (_it.Begin (); _it.Next ();) {
  var q = 0;
   if (_aspect.Component129Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component129Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component223Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component223Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component177Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component177Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component18Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component18Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
