using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System110 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component289> _p1;
EcsPool<Component94> _p2;
EcsPool<Component213> _p3;
EcsPool<Component428> _p4;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component289>().Inc<Component94>().Inc<Component213>().Inc<Component428>().End();
   _p1 = _world.GetPool<Component289>();
   _p2 = _world.GetPool<Component94>();
   _p3 = _world.GetPool<Component213>();
   _p4 = _world.GetPool<Component428>();
 }
 public void Run (IEcsSystems systems) {
  foreach (int entity in _filter) {
  }
 }
}

}
