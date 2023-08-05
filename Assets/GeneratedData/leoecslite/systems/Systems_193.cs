using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System193 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component61> _p1;
EcsPool<Component438> _p2;
EcsPool<Component413> _p3;
EcsPool<Component433> _p4;
EcsPool<Component452> _pl0;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component61>().Inc<Component438>().Inc<Component413>().Inc<Component433>().End();
   _p1 = _world.GetPool<Component61>();
   _p2 = _world.GetPool<Component438>();
   _p3 = _world.GetPool<Component413>();
   _p4 = _world.GetPool<Component433>();
   _pl0 = _world.GetPool<Component452>();
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
