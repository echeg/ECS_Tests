using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System417 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component415> _p1;
EcsPool<Component245> _p2;
EcsPool<Component273> _p3;
EcsPool<Component356> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component415>().Inc<Component245>().Inc<Component273>().End();
   _p1 = _world.GetPool<Component415>();
   _p2 = _world.GetPool<Component245>();
   _p3 = _world.GetPool<Component273>();
   _pl0 = _world.GetPool<Component356>();
 }
 public void Run (IEcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
