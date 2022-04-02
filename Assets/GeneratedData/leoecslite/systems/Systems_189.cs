using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System189 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component171> _p1;
EcsPool<Component293> _p2;
EcsPool<Component408> _p3;
EcsPool<Component327> _p4;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component171>().Inc<Component293>().Inc<Component408>().Inc<Component327>().End();
   _p1 = _world.GetPool<Component171>();
   _p2 = _world.GetPool<Component293>();
   _p3 = _world.GetPool<Component408>();
   _p4 = _world.GetPool<Component327>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
  }
 }
}

}
