using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System343 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component329> _p1;
EcsPool<Component312> _p2;
EcsPool<Component307> _p3;
EcsPool<Component94> _p4;
EcsPool<Component362> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component329>().Inc<Component312>().Inc<Component307>().Inc<Component94>().End();
   _p1 = _world.GetPool<Component329>();
   _p2 = _world.GetPool<Component312>();
   _p3 = _world.GetPool<Component307>();
   _p4 = _world.GetPool<Component94>();
   _pl0 = _world.GetPool<Component362>();
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
