using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System103 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component405> _p1;
EcsPool<Component433> _p2;
EcsPool<Component111> _p3;
EcsPool<Component50> _pl0;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component405>().Inc<Component433>().Inc<Component111>().End();
   _p1 = _world.GetPool<Component405>();
   _p2 = _world.GetPool<Component433>();
   _p3 = _world.GetPool<Component111>();
   _pl0 = _world.GetPool<Component50>();
 }
 public void Run (EcsSystems systems) {
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
