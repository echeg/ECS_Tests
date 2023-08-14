using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System221 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component115> _p1;
EcsPool<Component118> _p2;
EcsPool<Component479> _p3;
EcsPool<Component403> _p4;
EcsPool<Component235> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component115>().Inc<Component118>().Inc<Component479>().Inc<Component403>().End();
   _p1 = _world.GetPool<Component115>();
   _p2 = _world.GetPool<Component118>();
   _p3 = _world.GetPool<Component479>();
   _p4 = _world.GetPool<Component403>();
   _pl0 = _world.GetPool<Component235>();
 }
 public void Run (IEcsSystems systems) {
  foreach (int entity in _filter) {
   if (_p1.Has(entity))
   {
    _p1.Del(entity);
   }
   else
   {
    _p1.Add(entity);
   }
  }
 }
}

}
