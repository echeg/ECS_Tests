using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System180 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component351> _p1;
EcsPool<Component77> _p2;
EcsPool<Component274> _p3;
EcsPool<Component408> _p4;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component351>().Inc<Component77>().Inc<Component274>().Inc<Component408>().End();
   _p1 = _world.GetPool<Component351>();
   _p2 = _world.GetPool<Component77>();
   _p3 = _world.GetPool<Component274>();
   _p4 = _world.GetPool<Component408>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
  }
 }
}

}
