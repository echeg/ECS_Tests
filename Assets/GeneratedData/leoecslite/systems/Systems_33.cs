using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System33 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component404> _p1;
EcsPool<Component246> _p2;
EcsPool<Component343> _p3;
EcsPool<Component360> _p4;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component404>().Inc<Component246>().Inc<Component343>().Inc<Component360>().End();
   _p1 = _world.GetPool<Component404>();
   _p2 = _world.GetPool<Component246>();
   _p3 = _world.GetPool<Component343>();
   _p4 = _world.GetPool<Component360>();
 }
 public void Run (IEcsSystems systems) {
  foreach (int entity in _filter) {
  }
 }
}

}
